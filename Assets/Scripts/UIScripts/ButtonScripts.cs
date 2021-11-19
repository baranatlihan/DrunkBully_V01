using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ButtonScripts : MonoBehaviour
{

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

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
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void NormalGameStart()
    {
        SceneManager.LoadScene(1);
    }

    public void RageGameStart()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame() {
        Application.Quit();
    }

}
