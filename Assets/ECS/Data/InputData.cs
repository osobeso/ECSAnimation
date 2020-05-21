using UnityEngine;
using Unity.Entities;

namespace ECSAnimation.Systems
{
    public struct InputData : IComponentData
    {
        public Vector2 movement;
        public Vector2 look;
        public bool interact;
        public bool crouch;
        public bool run;
        public bool jump;
    }
}