using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ButtonScripts : MonoBehaviour
{

    public void Menu()
    {
        isBackMenu();
    }

    public void Pause()
    {
        this.transform.GetChild(6).gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        this.transform.GetChild(6).gameObject.SetActive(false);
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

    public void Credits()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(2).gameObject.SetActive(false);
        this.transform.GetChild(1).gameObject.SetActive(true);

    }
    public void CreditsBackButton()
    {
        this.transform.GetChild(1).gameObject.SetActive(false);
        this.transform.GetChild(0).gameObject.SetActive(true);
        this.transform.GetChild(2).gameObject.SetActive(true);
    }

    public void ExitGame() {
        Application.Quit();
    }

    public void BacktoMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void BacktoGame()
    {
        this.transform.GetChild(5).gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    void isBackMenu()
    {
        this.transform.GetChild(5).gameObject.SetActive(true);
        Time.timeScale = 0;
    }



}
