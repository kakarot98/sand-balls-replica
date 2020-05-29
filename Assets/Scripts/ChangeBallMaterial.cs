using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBallMaterial : MonoBehaviour
{
    public Material[] materials;

    Renderer rendererVar;

    private void Start()
    {
        rendererVar = GetComponent<Renderer>();
        rendererVar.enabled = true;
        rendererVar.sharedMaterial = materials[0];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ColouredBalls") {
            rendererVar.sharedMaterial = materials[1];
        }
    }
}
