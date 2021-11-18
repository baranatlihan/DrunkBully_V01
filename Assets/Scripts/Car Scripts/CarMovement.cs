using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    private Vector3 speedVec = new Vector3(0, 0, 0);

    private Vector3 jumpVec = new Vector3(0, 10, 0);

    [HideInInspector]
    public float speed = 0f;
    [InspectorName("True = X, False = Z")]
    public bool AxisRotate = true;

    private float ForceY;
    private bool wait = true;
    private bool control = true;
    void Start()
    {
        control = true;


        if (AxisRotate && wait == true)
        {
            speedVec.Set(GameManager.staticSpeed, 0, 0);
        }



        else if (wait)
        {
            gameObject.transform.Rotate(0, 270, 0);
            speedVec.Set(0, 0, GameManager.staticSpeed);
        }
        

        
        
    }
    
   
    void Update()
    {
        if (control)
        {
            gameObject.transform.localPosition += speedVec * Time.deltaTime;
        }
        else
        {
            gameObject.transform.localPosition += jumpVec * Time.deltaTime;
        }

            
    }

    void OnCollisionEnter(Collision dest)
    {
        if (dest.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && GameManager.staticRage)
        {
            control = false;
            Destroy(this.gameObject, 2.5f);

        }

    }

}
