using ECSAnimation.Systems;
using System;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

/// <summary>
/// Hero is our guy
/// It's holding the two animation controllers, and also holding the Transform and rotation of these guys.
/// </summary>
public class Hero : MonoBehaviour, IConvertGameObjectToEntity
{
    Animator bodyAnimator;
    Animator legsAnimator;

    private Entity entity;
    private Entity bodyAnimationEntity;
    private Entity legsAnimationEntity;
    private EntityManager entityManager;
    private readonly Dictionary<AnimationTriggerNames, string> animations = new Dictionary<AnimationTriggerNames, string>();

    private const string BodyAnimatorGameObjectContainerName = "UpperBody";
    private const string LegsAnimatorGameObjectContainerName = "LowerBody";

    // Start is called before the first frame update
    void Start()
    {
        // Get both body and legs animators from component.
        bodyAnimator = GameObject.Find($"Hero/{BodyAnimatorGameObjectContainerName}").GetComponentInChildren<Animator>();
        legsAnimator = GameObject.Find($"Hero/{LegsAnimatorGameObjectContainerName}").GetComponentInChildren<Animator>();

        entityManager.AddComponentData(entity, new InputData { crouch = false, interact = false, look = Vector2.zero, movement = Vector2.zero, run = false });
        entityManager.AddComponentData(entity, new MoveData { direction = float3.zero, speed = 0 });
        entityManager.AddComponentData(entity, new FaceTowardsData { faceTowards = float3.zero });

        var legsAnimationArchetype = entityManager.CreateArchetype(typeof(AnimationTriggerData), typeof(LegsAnimationTag), typeof(InputData));
        var bodyAnimationArchetype = entityManager.CreateArchetype(typeof(AnimationTriggerData), typeof(BodyAnimationTag), typeof(InputData));

        // Body animation entity.
        bodyAnimationEntity = entityManager.CreateEntity(bodyAnimationArchetype);
        entityManager.AddComponentData(bodyAnimationEntity, new AnimationTriggerData { name = AnimationTriggerNames.BodyIdle });
        entityManager.AddComponentData(bodyAnimationEntity, new BodyAnimationTag()); //  Mark as Body on ECS
        entityManager.AddComponentData(bodyAnimationEntity, new InputData { crouch = false, interact = false, look = Vector2.zero, movement = Vector2.zero, run = false });

        // Legs animation entity.
        legsAnimationEntity = entityManager.CreateEntity(legsAnimationArchetype);
        entityManager.AddComponentData(legsAnimationEntity, new AnimationTriggerData { name = AnimationTriggerNames.BodyIdle });
        entityManager.AddComponentData(legsAnimationEntity, new LegsAnimationTag()); // Mark as Legs on ECS
        entityManager.AddComponentData(legsAnimationEntity, new InputData { crouch = false, interact = false, look = Vector2.zero, movement = Vector2.zero, run = false });
    }

    // Update is called once per frame
    void Update()
    {
        var translation = entityManager.GetComponentData<Translation>(entity);
        var rotation = entityManager.GetComponentData<Rotation>(entity);
        transform.position = new Vector2(translation.Value.x, translation.Value.y);
        transform.rotation = rotation.Value;

        var upperAnimationData = entityManager.GetComponentData<AnimationTriggerData>(bodyAnimationEntity);
        var lowerAnimationData = entityManager.GetComponentData<AnimationTriggerData>(legsAnimationEntity);

        var bodyAnimationTrigger = GetAnimationTrigger(upperAnimationData.name);
        var legsAnimatorTrigger = GetAnimationTrigger(lowerAnimationData.name);

        // Don't forget to set animator triggers!
        legsAnimator.SetTrigger(legsAnimatorTrigger);
        bodyAnimator.SetTrigger(bodyAnimationTrigger);
    }

    /// <summary>
    /// Returns the animation trigger value by using a cached dictionary first
    /// And resorting into Enum.Getname last.
    /// A dictionary is a lot faster than reflection.
    /// </summary>
    /// <param name="animationEnum">The animation enum to get the name from.</param>
    /// <returns>Returns the name representation of the enum.</returns>
    private string GetAnimationTrigger(AnimationTriggerNames animationEnum)
    {
        if (animations.ContainsKey(animationEnum))
        {
            return animations[animationEnum];
        }
        var name = Enum.GetName(typeof(AnimationTriggerNames), animationEnum);
        animations.Add(animationEnum, name);
        return name;
    }

    /// <summary>
    /// Converts the current GameObject into an entity.
    /// Currently it's only used to get the references to the entity and the entity manager.
    /// </summary>
    /// <param name="entity">The entity that gets created from this mono GameObject.</param>
    /// <param name="dstManager">The Entity Manager.</param>
    /// <param name="conversionSystem">Conversion system of the process.</param>
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        if (!enabled)
        {
            return;
        }
        this.entity = entity;
        entityManager = dstManager;
    }
}
