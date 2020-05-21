using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace ECSAnimation.Systems
{
    /// <summary>
    /// We want the update system to update after the movement input system
    /// because  the movement system depends upon the outcome of the input calculation.
    /// </summary>
    [UpdateAfter(typeof(MovementInputSystem))]
    public class MovementSystem : ComponentSystem
    {
        protected override void OnUpdate()
        {
            var delta = Time.DeltaTime;
            Entities.ForEach((ref Translation pos, ref MoveData move) =>
            {
                float3 normalizedDir = math.normalizesafe(move.direction);

                pos.Value += normalizedDir * move.speed * delta;
            });
        }
    }
}
