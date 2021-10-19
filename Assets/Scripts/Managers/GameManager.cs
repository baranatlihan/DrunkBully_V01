using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public float ControlTime = 0f;
    static public float staticExitTime = 0f;
    static public float staticSpeed = 1.75f;
    System.Random random = new System.Random();


    [Header("Humans Settings")]
    public GameObject[] humans;
    [HeaderAttribute("Human lifetime and exit points")]
    public float exitTime;

    [Header("Cars Settings")]
    public GameObject[] cars;
    [HeaderAttribute("Human lifetime and exit points")]
    public float Speed;



    private void Awake()
    {
        staticSpeed = Speed;
    }

    void Start()
    {
        staticExitTime = exitTime;      
    }

    // Update is called once per frame
    void Update()
    {
        ControlTime += Time.deltaTime;


       

    }





}
