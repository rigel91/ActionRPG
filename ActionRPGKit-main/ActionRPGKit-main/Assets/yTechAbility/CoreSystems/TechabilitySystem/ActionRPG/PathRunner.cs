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
                     
            return false;
        }

        float GetDistanceTo(Transform other)
        {
           
            return 0;
        }

        Vector3 GetDirectionTo(Transform other)
        {
          

            return Vector3.zero;
        }

        void NextPathPoint()
        {
           
        }
    }
}
