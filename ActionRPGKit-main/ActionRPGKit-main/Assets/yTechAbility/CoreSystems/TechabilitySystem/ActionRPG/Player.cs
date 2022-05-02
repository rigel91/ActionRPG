using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace Techability.Systems
{
    public class Player : StudentPlayer
    {
        //public float turnRate = 30f; 
        MouseToWorld MTW;


        public Animator ani;


        public Transform ModelRoot;


        bool IsWalking = false;
        bool IsDead = false;
        bool Swing = false;
        bool Aim = false;
        bool Shoot = false;

        NavMeshAgent agent;

        void Start()
        {
            MTW = gameObject.GetComponent<MouseToWorld>();
            agent = gameObject.GetComponent<NavMeshAgent>();
        }


        void Update()
        {
            // 1. Update The Mouse to World script with the current Mouse. 
           
            // 2. Get Mouse down, when down tell agent to move to MTW.WorldPosition
           
            // 3. Walking Animation Control 
            
        }
        void UpdateFacing()
        {
            Vector3 direction = (MTW.worldPosition - ModelRoot.position);
            
            // Keeps the player from rotating to the MTW world point when it's close! 
            direction.y = 0;
            
            if (direction.magnitude > .1f)
            {
                gameObject.transform.forward = direction.normalized;
            }
        }
    }
}
