using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace Techability.Systems
{
    public class OrbCounter : MonoBehaviour
    {
        public int triggercount = 0;
        public UnityEvent onComplete;

        void Start()
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

        public void OnTriggerEnter(Collider other)
        {
           
            Bobber Orb = other.GetComponentInParent<Bobber>();
            if (Orb)
            {
                
                triggercount++;

                if (triggercount >= 3)
                {
                    onComplete?.Invoke(); 
                }
            }
        }

    }
}