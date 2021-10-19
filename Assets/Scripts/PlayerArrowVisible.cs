using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArrowVisible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.GetChild(2).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.GetChild(2).gameObject.SetActive(false);
        }
    }
}
