using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{

    [Header("Lights Settings")]
    public bool lightsOut = false;
    public GameObject lightObj;

    [Header("Explode Settings")]
    public bool explode = false;
    public Transform[] explodeObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(true);

            if (explode)
            {
                ExplodeEffect();
            }
                


            if (lightsOut)
            {
                lightObj.transform.gameObject.SetActive(false);
            }

            Destroy(this.gameObject, 5);
        }


    }


    void ExplodeEffect()
    {
        for (int i = 0; i < explodeObj.Length; i++)
        {
            explodeObj[i].GetComponent<Rigidbody>().AddForce(0, 7f, 0, ForceMode.Impulse);
        }
    }

    
}

/*
 * 5 saniye sonra yok et, Ayrý bir script: yeniden yarat. Bool control
 * 
 * Ekstralar:
 * ýþýðý söndürme, yaratýnca yeniden yakma!!! ayrý bir fonk olabilir.
 * 
 */
