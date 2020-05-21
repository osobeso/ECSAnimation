using Unity.Entities;

namespace ECSAnimation.Systems
{
    /// <summary>
    /// Controls the animation for the upper part of the body.
    /// </summary>
    public class BodyAnimationSystem : ComponentSystem
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((ref AnimationTriggerData animationData, ref BodyAnimationTag animationType, ref InputData inputData) =>
            {
                if (inputData.jump && !inputData.crouch)
                {
                    animationData.name = AnimationTriggerNames.BodyJump;
                    return;
                }

                // Magnitude greater than 0 means the player is moving.
                if (inputData.movement.magnitude > 0)
                {
                    if (inputData.crouch)
                    {
                        animationData.name = AnimationTriggerNames.BodyCrouchWalk;
                    }
                    else if (inputData.run)
                    {
                        animationData.name = AnimationTriggerNames.BodyRun;
                    }
                    else
                    {
                        animationData.name = AnimationTriggerNames.BodyWalk;
                    }
                }
                else
                {
                    if (inputData.crouch)
                    {
                        animationData.name = AnimationTriggerNames.BodyCrouch;
                    }
                    else
                    {
                        animationData.name = AnimationTriggerNames.BodyIdle;
                    }
                }
            });
        }
    }
}

