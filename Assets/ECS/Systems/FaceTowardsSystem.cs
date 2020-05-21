using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace ECSAnimation.Systems
{
    /// <summary>
    /// Face towards system needs to update after the Look Input system
    /// for the same reason of the MovementInput-Movement dependency.
    /// We need to calculate the input before we know where hero should face towards.
    /// </summary>
    [UpdateAfter(typeof(LookInputSystem))]
    public class FaceTowardsSystem : ComponentSystem
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((ref Translation pos, ref Rotation rot, ref FaceTowardsData faceTowards) =>
            {
                if(faceTowards.faceTowards.x == 0f && faceTowards.faceTowards.y == 0f)
                {
                    return;
                }

                var angle = Mathf.Atan2(faceTowards.faceTowards.y, faceTowards.faceTowards.x) * Mathf.Rad2Deg;
                rot.Value = Quaternion.Euler(0, 0, angle - 270);
            });
        }
    }
}
