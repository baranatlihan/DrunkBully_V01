using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public GameObject pointWine;

    [HideInInspector]
    public int point = 0;

    private void Awake()
    {
        PlayerPrefs.SetInt("deadCount", PlayerPrefs.GetInt("deadCount"));
        Debug.Log("AWAKE:" + PlayerPrefs.GetInt("deadCount"));
    }
    private void Start()
    {
        GameManager.ControlTime = 0;
        point = PlayerPrefs.GetInt("deadCount");
        if (point > 240)
        {
            point = 242;
        }else if (point < 100)
        {
            point = 66;
        }

        Time.timeScale = 1;
        Debug.Log("START:" + PlayerPrefs.GetInt("deadCount"));
    }

    private void Update()
    {
        GameManager.ControlTime += Time.deltaTime;
        if (GameManager.ControlTime < point / 22  ){
            Debug.Log(GameManager.ControlTime + "asd");
            pointWine.transform.position += new Vector3(0, 0.125f, 0) * Time.deltaTime;
        }
        else {
            //2sn delay eklemek lazým buraya
            ShowPointBottle();
            SceneManager.LoadScene(0);
        }



    }
    void ShowPointBottle()
    {            
        PlayerPrefs.SetInt("deadCount", 0);//killcounter
      
    }





}
