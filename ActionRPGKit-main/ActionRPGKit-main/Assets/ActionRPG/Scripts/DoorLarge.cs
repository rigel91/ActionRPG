using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLarge : MonoBehaviour
{
    public GameObject LeftDoor;
    public GameObject RightDoor;
    public Vector3 LeftDoorOpenLocation;
    public Vector3 RightDoorOpenLocation;
    public bool ClosedAtStart = true; 
    public Vector3 LeftDoorCloseLocation;
    public Vector3 RightDoorCloseLocation;

    public void Start()
    {
        if (ClosedAtStart)
        {
            if (LeftDoor)
            { 
                LeftDoorCloseLocation = LeftDoor.transform.localPosition; 
            }

            if (RightDoor)
            {
                RightDoorCloseLocation = RightDoor.transform.localPosition;
            }
        }
    }

    public void OpenDoor()
    {
        if (LeftDoor)
        {
            LeftDoor.transform.localPosition = LeftDoorOpenLocation;
        }

        if (RightDoor)
        {
            RightDoor.transform.localPosition = RightDoorOpenLocation;
        }
    }

    public void CloseDoor()
    {
        if (LeftDoor)
        {
            LeftDoor.transform.localPosition = LeftDoorCloseLocation;
        }

        if (RightDoor)
        {
            RightDoor.transform.localPosition = RightDoorCloseLocation;
        }
    }

}
