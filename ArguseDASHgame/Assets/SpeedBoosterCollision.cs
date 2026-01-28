using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoosterCollision : MonoBehaviour
{
    public float boostSpeed;
    public float duration;


    private void OnTriggerEnter2D(Collider2D other)
    {
        
        //PlayerController player = other.GetComponent<PlayerController>();
        PlayerController player=other.GetComponentInParent<PlayerController>();

        if (player == null)
        {
            Debug.Log("Player not found");
            return;
           
        }
       
        player.BoostSpeed(boostSpeed,duration);
    }
}
