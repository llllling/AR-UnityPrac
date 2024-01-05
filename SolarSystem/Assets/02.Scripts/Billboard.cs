using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    Transform camTransform;
    // Start is called before the first frame update
    void Start()
    {
        camTransform = GameObject.Find("ARCamera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(camTransform.position);
    }
}
