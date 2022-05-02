using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbFlicker : MonoBehaviour
{
    Light orbLight;
    public float offset = 0;
    public bool isActive = true;
    public float floor = 1f;
    public float range = 1f;
    public float frequency = 1f; 
    void Start()
    {
        orbLight = gameObject.GetComponent<Light>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        { 
            offset += Time.deltaTime;
            float value = floor + ( Mathf.Sin(offset * frequency) * range ) ;
            orbLight.intensity = value; 
        }
    }
}
