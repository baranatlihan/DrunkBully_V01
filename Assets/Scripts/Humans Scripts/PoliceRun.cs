using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PoliceRun : MonoBehaviour
{
    public Transform player;
    private string tagName;
    NavMeshAgent myNavMeshAgent;
    private bool control = true;
    void Awake()
    {      
        player = GameObject.FindGameObjectWithTag("Player").transform;
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        control = true;
    }
    void Update()
    {
        if (control)
        {
            myNavMeshAgent.SetDestination(player.position);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cars")
        {
            control = false;
            tagName = other.gameObject.tag;
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            Destroy(this.gameObject, 5);
        }     
        transform.GetChild(1).Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, 4f, 0, ForceMode.Impulse);
        transform.GetChild(1).Find("Armature").Find("node_id5").GetComponent<Rigidbody>().AddForce(0.2f, 0.2f, 0.2f, ForceMode.Impulse);       
    }

}
