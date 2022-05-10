using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Techability.Systems
{
    public class PathRunner : MonoBehaviour
    {
        public bool facesPoint = true; 
        public bool hasDynamicFacing = true; 
        public float speed = 0;
        public float withInRange = .1f;
        public Transform[] pathList;
        public int pathIndex = 0;
        public UnityEvent<Transform> ReachedPathPoint; 

        Transform currentPathPoint;
        Vector3 currentDirection; 

        void Start()
        {
            currentPathPoint = pathList[pathIndex];
            currentDirection = GetDirectionTo(currentPathPoint); 
        }

        // Update is called once per frame
        void Update()
        {
           
            if (hasDynamicFacing)
            {
                currentDirection = GetDirectionTo(currentPathPoint);
            }
            if (facesPoint)
            {
                gameObject.transform.forward = currentDirection; 
            }

            Vector3 position = gameObject.transform.position;
            position += currentDirection * speed * Time.deltaTime; 
            gameObject.transform.position = position;

            if (IsClose())
            {
                ReachedPathPoint?.Invoke(currentPathPoint);
                NextPathPoint();
                currentDirection = GetDirectionTo(currentPathPoint);
            }
        }

        public void SayPathPointName(Transform pathPoint)
        {
            Debug.Log("Reached " + pathPoint.name); 
        }    

        bool IsClose()
        {
            //is the ghost close enough to the pillar
            
            if(GetDistanceTo(currentPathPoint) <= withInRange)
            {
                return true;
            }
            return false;














            // Option 1: If statement
            // use GetDistanceTo function here check it's result against withInRange
            //if (GetDistanceTo(currentPathPoint) <= withInRange)
            //{
            //    return true;
            //}

            //// starting stub code
            //return false;

            // Option 2: single line retrurn
            // return (GetDistanceTo(currentPathPoint) <= withInRange);
        }

        float GetDistanceTo(Transform other)
        {
            //distance from one position to another
            Vector3 distance = other.position - gameObject.transform.position;
            return distance.magnitude;
















            // Option 1
            // Vector3 distance = other.position - gameObject.transform.position;
            // return distance.magnitude; 

            // Option 2
            //return (other.position - gameObject.transform.position).magnitude;


            // starting stub code
            //return 0;
        }

        Vector3 GetDirectionTo(Transform other)
        {
            //get direction from one pillar to another
            Vector3 distance = other.position - gameObject.transform.position;
            return distance.normalized;













            // Option 1
            // Vector3 distance = other.position - gameObject.transform.position;
            // return distance.normalized; 

            // Option 2
            //return (other.position - gameObject.transform.position).normalized;

            // starting stub code
            //return 0;
        }

        void NextPathPoint()
        {
            //go to the next point in our path

            pathIndex++;
            if (pathIndex >= pathList.Length)
            {
                pathIndex = 0;
            }
            currentPathPoint = pathList[pathIndex];
        }
    }
}
