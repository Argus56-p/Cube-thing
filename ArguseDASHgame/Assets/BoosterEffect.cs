using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterEffect : MonoBehaviour
{
    public float RotateSpeed;
    public float pulseSpeed;
    public float pulseAmount;

    private Vector3 startScale;
    
    void Start()
    {
        startScale = transform.localScale;  
    }

    
    void Update()
    {

        transform.Rotate(0f, 0f, RotateSpeed * Time.deltaTime);
        float pulse = 1f + Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;
        transform.localScale = startScale * pulse;
            
    }
}
