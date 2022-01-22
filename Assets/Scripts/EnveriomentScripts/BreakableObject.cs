using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(true);
            Destroy(this.gameObject, 5);
        }


    }
}

/*
 * 5 saniye sonra yok et, Ayr� bir script: yeniden yarat. Bool control
 * 
 * Ekstralar:
 * ����� s�nd�rme, yarat�nca yeniden yakma!!! ayr� bir fonk olabilir.
 * 
 */
