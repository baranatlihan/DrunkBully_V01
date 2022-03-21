using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollDestroyObjectScript : MonoBehaviour
{
    public float destroyTime = 5;

    private float force;
    void Start()
    {
        Destroy(this.gameObject, destroyTime);

        if (GameManager.staticRage)
        {
            force = 5f;
        }
        else force = 3f;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(force);

        if (other.tag == "Cars")
        {
            transform.Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, 5f, 0, ForceMode.Impulse);
        }
        else
        {
            transform.Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce(0, force, 0, ForceMode.Impulse);
        }

    }


}
