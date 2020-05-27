using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeformPlane : MonoBehaviour
{

    MeshFilter meshFilter;

    Mesh PlaneMesh;

    Vector3[] vertices;
    [SerializeField]
    float radius = default;
    [SerializeField]
    float power = default;

    private void Start()
    {
        meshFilter = GetComponent<MeshFilter>();

        PlaneMesh = meshFilter.mesh;

        vertices = PlaneMesh.vertices;
    }

    public void DeformThisPlane(Vector3 positionToDeform) {
        positionToDeform = transform.InverseTransformPoint( positionToDeform );
        
        for (int i = 0; i < vertices.Length; i++) {
            float distance = (vertices[i] - positionToDeform).sqrMagnitude;

            if (distance < radius) {
                vertices[i] -= Vector3.up * power;

            }
        }

        PlaneMesh.vertices = vertices;
    }
}
