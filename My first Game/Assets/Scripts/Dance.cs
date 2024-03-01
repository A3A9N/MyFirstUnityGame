using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to a GameObject with an Animator component attached.
//For this example, create parameters in the Animator and name them “Crouch” and “Jump”
//Apply these parameters to your transitions between states

//This script allows you to trigger an Animator parameter and reset the other that could possibly still be active. Press the up and down arrow keys to do this.

public class Example : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_Animator.SetTrigger("Dance");
        }

    }
}