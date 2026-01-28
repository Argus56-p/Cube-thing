using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmover2 : MonoBehaviour
{
    public Transform[] backgrounds;
    public Camera cam;

    public float width;
    public float height;

    void Update()
    {
        if (!cam) return;
        Vector3 c = cam.transform.position;
        float stepX = width * 2f;
        float stepY = height * 2f;

        foreach (var t in backgrounds)
        {
            Vector3 p = t.position;

            if (c.x - p.x > width) p.x += stepX;
            else if (p.x - c.x > width) p.x -= stepX;

            if (c.y - p.y > height) p.y += stepY;
            else if (p.y - c.y > height) p.y -= stepY;

            t.position = p;
        }



    }
}

