using Unity.Entities;
using Unity.Mathematics;

namespace ECSAnimation.Systems
{
    public struct FaceTowardsData : IComponentData
    {
        public float3 faceTowards;
    }
}
