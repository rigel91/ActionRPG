using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Techability.Systems;
using UnityEngine.AI; 

public class TeleportPortal : MonoBehaviour
{
    public Transform TeleportPoint; 

    private void OnTriggerEnter(Collider other)
    {
        // Player is the primary script that defines our player object
        Player player = other.GetComponentInParent<Player>();
        
        if (player)
        {
            Debug.Log("Teleport: " + gameObject.name); 

            Transform tr = player.GetComponent<Transform>();
          
            tr.position = TeleportPoint.position;
            tr.rotation = TeleportPoint.rotation;

            NavMeshAgent agent = player.gameObject.GetComponent<NavMeshAgent>();
            if (agent)
            {
                agent.SetDestination(tr.position);
            }
            
        }
    }
}
