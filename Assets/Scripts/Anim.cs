﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour {

    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Trigger();
        }
    }
    public void Trigger()
    {
        
            anim.SetTrigger("Active");
        
    }
}
