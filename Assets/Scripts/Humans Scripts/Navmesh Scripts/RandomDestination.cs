using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomDestination : MonoBehaviour
{
    Vector3 vec = new Vector3(0,0,0);
    NavMeshAgent myNavMeshAgent;
    System.Random random = new System.Random();
    private float timeCount = 0f;
    //public Transform[] exitPoints;

    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        timeCount = 0f;
    }



    void Update()
    {       
        timeCount += Time.deltaTime;
        /*if (timeCount >= GameManager.staticExitTime)
        {
            SetExitPoint();
            this.gameObject.tag = "Escaper";
            timeCount = 0;
        }*/
        if (!myNavMeshAgent.hasPath)
        {
            SetRandomDest();
        }
        else if(myNavMeshAgent.remainingDistance <= 2.5)
        {
            SetRandomDest();
        }
    }

    void SetRandomDest()
    {
        vec.Set(random.Next(-20, 20), -0.5f, random.Next(-20, 20));
        myNavMeshAgent.SetDestination(vec);
    }

    /*void SetExitPoint()
    {
        myNavMeshAgent.SetDestination(exitPoints[random.Next(0, exitPoints.Length)].transform.position);
    }*/

}
