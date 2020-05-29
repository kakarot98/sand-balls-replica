using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera cam;
    float moveOffset = 2f;
    float mouseFollowStartPos = 250f; 

        
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0)) {
            if (Input.mousePosition.y < mouseFollowStartPos) {
                cam.transform.position = new Vector3(cam.transform.position.x, (cam.transform.position.y - moveOffset * Time.deltaTime), cam.transform.position.z);
            }
        }
    }
}
