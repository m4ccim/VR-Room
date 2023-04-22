using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{ 
    private readonly float speed = 50.0f;
    private Vector3 vector3;
    bool isScalingUp = true;
    readonly float scaleSpeed = 1f;
    readonly float maxScale = 1.5f;
    readonly float minScale = 0.5f;
    void Update()
    {

            vector3 = new Vector3(0, 1, 0);
            transform.Rotate(speed * Time.deltaTime * vector3); 
        
        // Scale the reticle up and down
        if (isScalingUp)
        {
            transform.localScale += scaleSpeed * Time.deltaTime * Vector3.one;
            if (transform.localScale.x >= maxScale)
            {
                isScalingUp = false;
            }
        }
        else
        {
            transform.localScale -= scaleSpeed * Time.deltaTime * Vector3.one;
            if (transform.localScale.x <= minScale)
            {
                isScalingUp = true;
            }
        }

    }
}