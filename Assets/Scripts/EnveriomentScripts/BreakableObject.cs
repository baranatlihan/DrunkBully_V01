using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    [HideInInspector]
    public int numb = 3;

    System.Random random = new System.Random();

    [Header("Lights Settings")]
    public bool lightsOut = false;
    public GameObject lightObj;

    [Header("Explode Settings")]
    public bool randomExplode = false;
    public bool explode = false;
    public Transform[] explodeObj;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            numb = random.Next(0, 5);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(true);



            if (explode)
            {
                ExplodeEffect();
            }

            if (randomExplode)
            {
                RandomExplodeEffect();
            }

            if (lightsOut)
            {
                lightObj.transform.gameObject.SetActive(false);
            }

            this.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 5);
        }


    }

    public void ExplodeEffect()
    {
        for (int i = 0; i < explodeObj.Length; i++)
        {
            explodeObj[i].GetComponent<Rigidbody>().AddForce(0, 6f, 0, ForceMode.Impulse);
        }
    }

    public void RandomExplodeEffect()
    {
        for(int i = 0; i < explodeObj.Length; i++)
        {
            if(random.Next(0, 5) < numb)
                explodeObj[i].GetComponent<Rigidbody>().AddForce(2f, 2.5f, -1f, ForceMode.Impulse);
            else
                explodeObj[i].GetComponent<Rigidbody>().AddForce(-1.5f, 1.75f, 2f, ForceMode.Impulse);

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
