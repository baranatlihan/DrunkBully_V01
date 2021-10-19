using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject[] humans;
    public Transform[] spawnPoints;
    public float SpawnTime = 0f;
    public bool SpawnWhenStart = false;
    private float timer = 0f;
    System.Random random = new System.Random();

    private void Start()
    {
        if (SpawnWhenStart)
        {

            SpawnHumans();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= SpawnTime)
        {
            timer = 0f;
            SpawnHumans();        
        }
    }  


    private void SpawnHumans()
    {
    
        if(spawnPoints.Length != 0) { 
        Instantiate(humans[random.Next(0, humans.Length)], spawnPoints[random.Next(0, spawnPoints.Length)].position, Quaternion.identity, transform.parent);
        }
        else
            Instantiate(humans[random.Next(0, humans.Length)], transform.position, Quaternion.identity, transform.parent);
    }


} 
