using Unity.Entities;

namespace ECSAnimation.Systems
{
    public struct AnimationTriggerData : IComponentData
    {
        public AnimationTriggerNames name;
    }

    public struct LegsAnimationTag : IComponentData
    {

    }

    public struct BodyAnimationTag : IComponentData
    {

    }
}

