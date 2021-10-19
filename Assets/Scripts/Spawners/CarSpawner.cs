using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    public GameObject[] Cars;
    public Transform[] spawnPoints;
    public float SpawnTime = 0f;
    public bool SpawnWhenStart = false;
    private float timer = 0f;
    System.Random random = new System.Random();

    private void Start()
    {
        if (SpawnWhenStart)
        {
            Debug.Log("spawnwhenstart");
            SpawnCar();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= SpawnTime)
        {
            timer = 0f;
            SpawnCar();
        }
    }


    private void SpawnCar()
    {        
        Instantiate(Cars[random.Next(0, Cars.Length)], spawnPoints[random.Next(0, Cars.Length)].position, Quaternion.Euler(0, 180, 0), transform.parent);      
    }

}
