using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [Tooltip("Tick it if you want to execute animation ")]
    public bool runAnimation = true;
    public Animation run;
    public bool walkAniomation = true;
    public Animation walk;
    public bool sadleAniomation = true;
    public Animation sadle;

    // Start is called before the first frame update
    void Start()
    {
        if (runAnimation)
        {
            Run();
        }

        if (walkAniomation)
        {
            Walk();
        }

        if (sadleAniomation)
        {
            Sadle();
        }

        
    }

    void Update()
    {
        if (runAnimation)
        {
            run.Play();
        }

        if (walkAniomation)
        {
            walk.Play();
        }

        if (sadleAniomation)
        {
            sadle.Play();
        }
        
    }


    void Run()
    {
        run = GetComponent<Animation>();
    }

    void Walk()
    {
        walk = GetComponent<Animation>();
    }

    void Sadle()
    {
        sadle = GetComponent<Animation>();
    }


}
