using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Techability.Systems
{
    public class Bobber : MonoBehaviour
    {
        public float speed = 10;
        public float height = 3;
        bool isMovingUp = true;
        Vector3 startingPosition = Vector3.zero;
        float topPoint = 0; 

        void Start()
        {
            // 1. Get the object's position and store in starting point 
            startingPosition = gameObject.transform.position;

            // 2. Add Height to startingPosition.y to get the top point. 
            topPoint = startingPosition.y + height;













            // 1. Get the object's position and store in starting point 
            startingPosition = transform.position;

            // 2. Add Height to startingPosition.y to get the top point. 
            topPoint = startingPosition.y + height;
            
        }


        void Update()
        {
            // 1. Move the Object up or down depending on IsMovingup


            // 2. Check if the object is above the top point 
            //    We're only checking against the y value of the postion
            //      If so, isMovingUp should be false
            //      optional: place the object at the top point. 


            // 3. Check if the object is below the starting point.
            //    We're only checking against the y value of the postion
            //      If so, isMovingUp should be true
            //      optional: place the obect at the starting point. 











            // 1. Move the Object up or down depending on IsMovingup
            Vector3 currentLocation = transform.position;
            if (isMovingUp)
            {
                currentLocation.y += speed * Time.deltaTime;
            }
            else
            {
                currentLocation.y -= speed * Time.deltaTime;
            }
            transform.position = currentLocation;

            // 2. Check if the object is above the top point 
            //    We're only checking against the y value of the postion
            //      If so, isMovingUp should be false
            //      optional: place the object at the top point. 
            if (transform.position.y >= topPoint)
            {
                isMovingUp = false;
            }

            // 3. Check if the object is below the starting point.
            //    We're only checking against the y value of the postion
            //      If so, isMovingUp should be true
            //      optional: place the obect at the starting point. 
            if (transform.position.y <= startingPosition.y)
            {
                isMovingUp = true;
            }

        }
    }
}
