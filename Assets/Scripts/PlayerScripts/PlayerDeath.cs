using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerDeath : MonoBehaviour
{
    private string tagName;
    public GameObject joystick;
    public GameObject timeText;
    [HideInInspector]
    public bool isDead = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Police" ^ other.gameObject.tag == "Cars" && !GameManager.staticRage)
        {
            isDead = true;
            tagName = other.gameObject.tag;
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            joystick.SetActive(false);
            timeText.SetActive(false);
            GetComponent<PlayerControl>().enabled = false;
        }


        if (tagName == "Police")
        {
            transform.GetChild(1).Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, 2f, 0, ForceMode.Impulse);
        }
        else
        {
            transform.GetChild(1).Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, 4.2f, 0, ForceMode.Impulse);
        }    
    }    
}
