using ECSAnimation.Systems;
using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// Movement Input system is the bridge system between Input system and MoveSystem.
/// We need a bridge because movement system should not care about anything else than moving an entity.
/// And the Input System from ECS should not care about anything else but what input is currently active.
/// </summary>
public class MovementInputSystem : ComponentSystem
{
    private const float CrouchSpeed = 1f;
    private const float RunningSpeed = 6f;
    private const float WalkSpeed = 3f;

    protected override void OnUpdate()
    {
        Entities.ForEach((ref InputData inputData, ref MoveData moveData, ref FaceTowardsData faceTowards) =>
        {
            if (inputData.movement.magnitude > 0)
            {
                moveData.direction = new float3(inputData.movement.x, inputData.movement.y, moveData.direction.z);
                if (inputData.crouch)
                {
                    moveData.speed = CrouchSpeed;
                    return;
                }

                if (inputData.run)
                {
                    moveData.speed = RunningSpeed;
                    return;
                }

                moveData.speed = WalkSpeed;
            }
            else
            {
                moveData.speed = 0;
                moveData.direction = float3.zero;
            }
        });
    }
}
