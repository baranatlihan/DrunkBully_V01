using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject joyStick;


    public void disableJoyStick()
    {
        this.gameObject.SetActive(false);
    }


}
