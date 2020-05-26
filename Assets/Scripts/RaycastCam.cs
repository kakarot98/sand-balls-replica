using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCam : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    Camera cam;

    private void Start()
    {
        cam = transform.GetComponent<Camera>();
    }
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0)) {
            DeformMesh();
        }
    }

    void DeformMesh() {
        ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) {
            //deform
            DeformPlane deformPlane = hit.transform.GetComponent<DeformPlane>();
            deformPlane.DeformThisPlane(hit.point);
        }
    }
}
