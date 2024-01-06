using System.Collections;
using System.Collections.Generic;
using UnityEditor.DeviceSimulation;
using UnityEngine;

public class TouchMgr : MonoBehaviour
{
    Camera arCam;
    void Start()
    {
        arCam = GameObject.Find("ARCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            CanvasActive(Input.mousePosition);
            
        }
#endif

#if UNITY_ANDROID || UNITY_IOS
        bool isFirstTouch =  Input.GetTouch(0).phase == UnityEngine.TouchPhase.Began;
        if(Input.touchCount > 0 && isFirstTouch) {
            CanvasActive(Input.GetTouch(0).position);
        }
#endif
    }

    void CanvasActive(Vector3 position)
    {
        if (Physics.Raycast(arCam.ScreenPointToRay(position), out RaycastHit hit, 100.0f, 1 << 8))
        {
            hit.transform.Find("Canvas").gameObject.SetActive(true);
        }
    }
}
