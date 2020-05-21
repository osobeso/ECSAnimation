using Unity.Entities;
using Unity.Mathematics;

namespace ECSAnimation.Systems
{
    public struct MoveData : IComponentData
    {
        public float3 direction;
        public float speed;
    }
}
