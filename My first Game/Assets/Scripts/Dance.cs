using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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