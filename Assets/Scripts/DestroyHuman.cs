using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHuman : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Escaper")
        {
            Destroy(other.gameObject);
        }
    }
}
