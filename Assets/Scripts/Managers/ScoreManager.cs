using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public GameObject pointWine;

    [HideInInspector]
    public int point = 0;


    private void Start()
    {
        GameManager.ControlTime = 0;
        point = PlayerPrefs.GetInt("deadCount");
        if (point > 240)
        {
            point = 242;
        }
        else if (point > 50)
        {
            point = 190;
        }
        else if (point >= 20 && point < 50)
        {
            point = 100;
        }
        else if (point < 20)
        {
            point = 50;
        }

        Time.timeScale = 1;

    }

    private void Update()
    {
        GameManager.ControlTime += Time.deltaTime;
        if (GameManager.ControlTime < point / 22  ){
            pointWine.transform.position += new Vector3(0, 0.125f, 0) * Time.deltaTime;
        }

        else if(GameManager.ControlTime > (point / 22)+3f  )
        {
            new WaitForSeconds(2);
            ShowPointBottle();
            SceneManager.LoadScene(0);
        }



    }
    void ShowPointBottle()
    {            
        PlayerPrefs.SetInt("deadCount", 0);//killcounter
      
    }





}
