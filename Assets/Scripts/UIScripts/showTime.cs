using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class showTime : MonoBehaviour
{

    public GameObject timeText;
    private float currentTime;
    private void Start()
    {
        currentTime = GameManager.staticLevelTime;
    }

    void Update()
    {
        currentTime = currentTime - Time.deltaTime;
        timeText.GetComponent<TextMeshProUGUI>().text = "" + ((int)currentTime);
    }
}
