using ECSAnimation.Systems;
using Unity.Entities;

/// <summary>
/// This system is responsible for updating the animation trigger of the Legs animator.
/// </summary>
public class LegsAnimationSystem : ComponentSystem
{
    /// <summary>
    /// Updates every iteration, which for some reason it's not necesarely related to the FPS.
    /// Good news are we still got Time.deltaTime's big brother: Time.DeltaTime
    /// </summary>
    protected override void OnUpdate()
    {
        Entities.ForEach((ref AnimationTriggerData animationData, ref LegsAnimationTag animationType, ref InputData inputData) =>
        {
            if (inputData.movement.magnitude > 0)
            {
                // For some reason the guy jumps two times.
                // Probably ECS fault and not my Animator controller skills.
                if(inputData.jump && !inputData.crouch)
                {
                    animationData.name = AnimationTriggerNames.LegsJump;
                    return;
                }
                if (inputData.crouch)
                {
                    animationData.name = AnimationTriggerNames.LegsCrouchWalk;
                }
                else if (inputData.run)
                {
                    animationData.name = AnimationTriggerNames.LegsRun;
                }
                else
                {
                    animationData.name = AnimationTriggerNames.LegsWalk;
                }
            }
            else
            {
                if (inputData.crouch)
                {
                    animationData.name = AnimationTriggerNames.LegsCrouch;
                }
                else
                {
                    animationData.name = AnimationTriggerNames.LegsIdle;
                }
            }
        });
    }
}
