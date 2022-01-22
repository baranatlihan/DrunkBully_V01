using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeEffectScript : MonoBehaviour
{
    public Transform[] explodeObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for(int i = 0; i < explodeObj.Length; i++)
            {
                Debug.Log("noob baran");
                explodeObj[i].GetComponent<Rigidbody>().AddForce(0, 5f, 0, ForceMode.Impulse);
            }
        }


        
    }
}
