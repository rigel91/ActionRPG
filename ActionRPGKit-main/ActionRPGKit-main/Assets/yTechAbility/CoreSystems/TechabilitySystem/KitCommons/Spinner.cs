using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public bool IsActive = true;
    public Vector3 SpinRate = Vector3.zero; 

    public void Stop()
    {
       
        IsActive = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (!IsActive)
        {
            return; 
        }

        gameObject.transform.Rotate(SpinRate * Time.deltaTime); 
        
    }
}
