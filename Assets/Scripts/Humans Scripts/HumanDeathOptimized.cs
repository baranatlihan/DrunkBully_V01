using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class HumanDeathOptimized : MonoBehaviour
{

    public GameObject ragdolObj;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cars" ^ other.gameObject.tag == "Player")
        {

            Destroy(this.gameObject);
            Instantiate(ragdolObj, transform.position, Quaternion.identity, transform.parent);


            PlayerPrefs.SetInt("deadCount", PlayerPrefs.GetInt("deadCount") + 1);//for playerprefs
            //ekrandaki skor sayisina +1, UImanager de ucarak kacarak �ekilli �ukllu puan artmas�(�i�e g�rseli olabilir ��pe biriken)
            //###POINT COUNTER FOR SCREEN HERE###
        }

    }   
            
}


