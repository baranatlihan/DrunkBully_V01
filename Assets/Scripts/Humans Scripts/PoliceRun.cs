using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PoliceRun : MonoBehaviour
{
    public Transform player;
    NavMeshAgent myNavMeshAgent;
    private bool control = true;
    public bool rage = false;
    int deadCount;
    void Awake()
    {      
        player = GameObject.FindGameObjectWithTag("Player").transform;
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        control = true;
    }

    private void Start()
    {
        this.gameObject.tag = "Police";
        
    }
    void Update()
    {
        if (control)
        {
            myNavMeshAgent.SetDestination(player.position);
        }

        if (this.gameObject.tag == "Dead")
        {
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cars" || other.gameObject.tag == "Light")
        {
            control = false;
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            this.gameObject.tag = "Dead";
            Destroy(this.gameObject, 3);
        }

        if(GameManager.staticRage && other.gameObject.tag == "Player" )
        {
            control = false;
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            Destroy(this.gameObject, 3);
            PlayerPrefs.SetInt("deadCount", PlayerPrefs.GetInt("deadCount") + 2);//for playerprefs   ### POLICE 2 POINTS ###
        }
        transform.GetChild(1).Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, 4f, 0, ForceMode.Impulse);
        transform.GetChild(1).Find("Armature").Find("node_id5").GetComponent<Rigidbody>().AddForce(0.2f, 0.2f, 0.2f, ForceMode.Impulse);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Cars")
        {
            this.gameObject.tag = "Dead";
        }
    }
}
