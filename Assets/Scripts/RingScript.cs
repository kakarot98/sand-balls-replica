using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingScript : MonoBehaviour
{

    //[SerializeField]
    //MeshCollider[] colliders;

    private void Start()
    {
        //foreach (var item in colliders) {
           // item.enabled = true;
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RingBlock") {
            Destroy(other.gameObject);
        }
    }
}
