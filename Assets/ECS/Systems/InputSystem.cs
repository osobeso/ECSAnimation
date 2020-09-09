using Unity.Entities;
using UnityEngine;
using UnityEngine.InputSystem;
using PlayerInput = ECSAnimation.Inputs.PlayerInput;

namespace ECSAnimation.Systems
{
    [AlwaysUpdateSystem]
    public class PlayerInputSystem : ComponentSystem
    {
        PlayerInput input;

        protected override void OnCreate()
        {
            base.OnCreate();
            input = new PlayerInput();
            input.Enable();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            input.Disable();
        }

        protected override void OnUpdate()
        {
            InputSystem.Update();

            var frameInput = new InputData
            {
                look = input.Player.LOOK.ReadValue<Vector2>(),
                movement = input.Player.MOVE.ReadValue<Vector2>(),
                crouch = input.Player.CROUCH.phase == InputActionPhase.Started,
                interact = input.Player.INTERACT.phase == InputActionPhase.Started,
                run = input.Player.RUN.phase == InputActionPhase.Started,
                jump = input.Player.JUMP.phase == InputActionPhase.Started,
            };


            Entities.ForEach((ref InputData inputData) =>
            {
                // Remember, we can't reference objects here, 
                // so we can't just do inputData = frameInput
                // We have to iterate trough each member to follow the rules of ECS.
                inputData.movement = frameInput.movement;
                inputData.crouch = frameInput.crouch;
                inputData.look = frameInput.look;
                inputData.interact = frameInput.interact;
                inputData.run = frameInput.run;
                inputData.jump = frameInput.jump;

            });
        }
    }
}