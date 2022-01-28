using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public float ControlTime = 0f;
    static public float staticExitTime = 0f;
    static public float staticSpeed = 1.75f;
    static public bool staticRage = false;
    System.Random random = new System.Random();


    [Header("Level Settings")]
    public float levelTime = 0;


    [Header("Player Settings")]
    public GameObject player;
    [HeaderAttribute("Human lifetime and exit points")]
    public float deadAfterMenuTime;

    [Header("Humans Settings")]
    public GameObject[] humans;
    [HeaderAttribute("Human lifetime and exit points")]
    public float exitTime;

    [Header("Cars Settings")]
    public GameObject[] cars;
    [HeaderAttribute("Human lifetime and exit points")]
    public float Speed;

    public bool rage = false;
    private float tmpTime=100;
    private bool ifBreaker = false;
    private void Awake()
    {
        staticSpeed = Speed;
        staticRage = rage;
        Time.timeScale = 1;
    }

    void Start()
    {
        staticExitTime = exitTime;
        ifBreaker = false;
        ControlTime = 0f;
    }

    // Update is called once per frame & ControlTime counting "total" time.
    void Update()
    {
        ControlTime += Time.deltaTime;

        if (ControlTime > levelTime)
        {
            SceneManager.LoadScene(3);            
        }

        DeadAfterMenu();
    }


    public void DeadAfterMenu()
    {
        if (player.GetComponent<PlayerDeath>().isDead == true && ifBreaker == false) 
        {
            tmpTime = ControlTime;
            ifBreaker = true;
        }

        if(tmpTime + deadAfterMenuTime < ControlTime)
        {
            SceneManager.LoadScene(0);
        }
    }


}
