using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Techability.Systems
{
    public class MouseToWorld : MonoBehaviour
    {
        public Camera cam;
        public Vector3 worldPosition;
        public Transform sphere;
        public Vector3 MousePos;

        public void UpdateMouse(Vector3 MousePosin)
        {
            RaycastHit hitInfo;
            MousePos = MousePosin;
            worldPosition = Vector3.zero;
            //MousePos.z = 0; 
            Ray ray = cam.ScreenPointToRay(MousePos);
            if (Physics.Raycast(ray, out hitInfo))
            {
                worldPosition = hitInfo.point;
                if (sphere)
                {
                    sphere.position = worldPosition;
                }

            }
        }
    }
}
