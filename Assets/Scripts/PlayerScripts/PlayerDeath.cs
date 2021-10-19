using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerDeath : MonoBehaviour
{
    public GameObject joystick;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cars")
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<PlayerControl>().enabled = false;

            joystick.SetActive(false);
        }

        transform.GetChild(1).Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, 3.5f, 0, ForceMode.Impulse);


    }

}
