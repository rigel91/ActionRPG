using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum MonsterState
{
    OnPath, 
    AgroPlayer, 
    LostPlayer
}

public class MonsterExample : MonoBehaviour
{
    public MonsterState currentState = MonsterState.OnPath; 


    
    void Start()
    {
        
    }

   
    void Update()
    {
        
        switch (currentState)
        {
            case MonsterState.OnPath:
                {
                    UpdateOnPath(); 
                    return; 
                }
            case MonsterState.AgroPlayer:
                {
                    UpdateAgroPlayer();
                    return;
                }
            case MonsterState.LostPlayer:
                {
                    UpdateLostPlayer();
                    return;
                }
            default:
                {
                    Debug.Log("What did you do to my AI? You broke it!"); 
                    return; 
                }
        }

    }

    public void StartOnPath()
    {
        currentState = MonsterState.OnPath;
        // Do anything to get On Path State up and going
    }

    public void UpdateOnPath()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartAgroPlayer(); 
        }

        // OnPath Logic
        // 1. Move the Enemy
        // 2. Check if see the Enemy
        //      IF we do, go to AgroPlayer
    }

    public void StartAgroPlayer()
    {
        currentState = MonsterState.AgroPlayer;
        // Do anything to get Agro player State up and going
    }

    public void UpdateAgroPlayer()
    {
        // Why?
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartLostPlayer();
        }

        // AGro Logic 
        // IF still sees player
        //    1. Move to it 
        //    2. Attack if in Range
        // If it doesn't see the player anmore
        //   Go to Lost Player 

    }

    public void StartLostPlayer()
    {
        currentState = MonsterState.LostPlayer;
        // Do anything to get Lost player State up and going
    }

    public void UpdateLostPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartOnPath();
        }

        // Lost Player Logic 
        // 1. Try and find player
        // If can't 
        //   Go back to wandering it's path. 
    }

}
