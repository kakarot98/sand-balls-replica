using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCam : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    Camera cam;

    public Transform ringPrefab = default;

    Vector3 lastPos;

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
        if ((lastPos = Input.mousePosition).sqrMagnitude > 2)
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                DeformPlane deformthePlane = hit.transform.GetComponent<DeformPlane>();
                deformthePlane.DeformThisPlane(hit.point);

                Instantiate(ringPrefab, new Vector3(hit.point.x, hit.point.y, hit.point.z - 0.11f), Quaternion.Euler(-90, 0, 0));


            }
            lastPos = Input.mousePosition;
        }
    }
}
