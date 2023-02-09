using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carsMovment : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0.02f, 0);
    }
}
