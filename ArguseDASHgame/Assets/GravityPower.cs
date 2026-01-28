using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPower : MonoBehaviour
{
    public float gravityScale;
    public float effectDuration;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player == null) return;
        player.GravityPower(gravityScale, effectDuration);
    }

}
