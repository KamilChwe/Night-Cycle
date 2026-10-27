using UnityEngine;

namespace Assets.Scripts
{
    class Player
    {
        public CharacterController Controller
        {  get; set; }

        public float Speed
        { get; set; }

        public GameObject LookingAt
        { get; set; }
    }
}
