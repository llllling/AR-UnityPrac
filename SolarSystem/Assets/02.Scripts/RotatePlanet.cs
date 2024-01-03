using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public float rotateSpeed = 10.0f;
    public Transform rotateBaseTransform = null;
    void Start()
    {
        
    }

    void Update()
    {
     transform.RotateAround(rotateBaseTransform.position, Vector3.up, rotateSpeed);   
    }
}
