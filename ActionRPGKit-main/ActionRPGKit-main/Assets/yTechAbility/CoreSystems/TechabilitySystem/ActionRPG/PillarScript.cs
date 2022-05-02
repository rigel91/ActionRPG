using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Techability.Systems; 

public class PillarScript : MonoBehaviour
{
    public EnemyCountManager CountManager;
    public GameObject FireOff;
    public GameObject FireOn;
    public GameObject FireEffect;
    bool hasBeenLit = false;

    private void OnTriggerEnter(Collider other)
    {
        PathRunner runner = other.GetComponentInParent<PathRunner>(); 
        if (runner)
        {
            Debug.Log("Runner"); 
            if (!hasBeenLit)
            {
                CountManager.RemoveEnemy(gameObject);
                FireOff.SetActive(false);
                FireOn.SetActive(true);
                FireEffect.SetActive(true);
            }
        }    
    }


}
