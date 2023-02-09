using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepMovement : MonoBehaviour
{
    float moveSpeed = 0.02f;
    float steerSpeed = 0.5f;
    float moveAmount;
    float steerAmount;

    void Start()
    {
        
    }
    void Update()
    {
        moveAmount = Input.GetAxis("Vertical")*moveSpeed;
        steerAmount = Input.GetAxis("Horizontal")*steerSpeed;
        transform.Translate(0, moveAmount, 0);
        if (moveAmount >= 0)
            transform.Rotate(0, 0, -steerAmount);
        else
            transform.Rotate(0, 0, steerAmount);

    }
}
