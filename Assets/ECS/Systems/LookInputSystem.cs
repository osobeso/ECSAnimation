using Unity.Entities;
using ECSAnimation.Systems;
using Unity.Transforms;
using Unity.Mathematics;

public class LookInputSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref InputData input, ref FaceTowardsData faceTowards, ref Translation translation) =>
        {
            var look = new float3(input.movement.x, input.movement.y, 0);
            faceTowards.faceTowards = look;
        });
    }
}
