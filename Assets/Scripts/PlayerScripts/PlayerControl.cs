using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Joystick joystick;



    public float speed;
    public float rotationSpeed;

    private void Awake()
    {
        joystick = FindObjectOfType<Joystick>();
    }


    void Update()
    {
       
            if (joystick.Horizontal > 0.2f || joystick.Horizontal < -0.2f || joystick.Vertical > 0.2f || joystick.Vertical < -0.2f)
            {
                transform.position += transform.forward * Time.deltaTime * speed * (Mathf.Abs(joystick.Vertical) + Mathf.Abs(joystick.Horizontal));
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, rotationCalculator(), 0), rotationSpeed * Time.deltaTime);
            }
    }

    private float rotationCalculator()
    {
        float calculation = Mathf.Atan2(joystick.Horizontal, joystick.Vertical) * 180 / Mathf.PI;
        return calculation;
    }
  

}
