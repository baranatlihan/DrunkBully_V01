using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ButtonScripts : MonoBehaviour
{
    
    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

}
