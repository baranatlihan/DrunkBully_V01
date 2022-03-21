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
            //ekrandaki skor sayisina +1, UImanager de ucarak kacarak þekilli þukllu puan artmasý(þiþe görseli olabilir çöpe biriken)
            //###POINT COUNTER FOR SCREEN HERE###
        }

    }   
            
}


