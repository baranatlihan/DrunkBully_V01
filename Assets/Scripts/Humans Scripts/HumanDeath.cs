using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class HumanDeath : MonoBehaviour
{

    private string tagName;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cars" ^ other.gameObject.tag == "Player")
        {
            tagName = other.gameObject.tag;
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            GetComponent<RandomDestination>().enabled = false;
            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            Destroy(this.gameObject, 5);
        }

        if (tagName == "Player")
        {
            Debug.Log("1");
            transform.GetChild(1).Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, 2f, 0, ForceMode.Impulse);
        }
        else
        {
            Debug.Log("2");
            transform.GetChild(1).Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, 4f, 0, ForceMode.Impulse);
        }







    }
}
