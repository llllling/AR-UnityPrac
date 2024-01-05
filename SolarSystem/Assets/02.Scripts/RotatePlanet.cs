using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Services;
using UnityEngine;
using Vuforia;

public class RotatePlanet : MonoBehaviour//, ITrackableEvent
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
