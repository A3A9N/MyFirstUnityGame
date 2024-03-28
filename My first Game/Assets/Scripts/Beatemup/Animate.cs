using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
    
     if (Input.GetAxis("Vertical") > 0){

     ani.SetTrigger("Walk");
     ani.ResetTrigger("Idle");
     ani.ResetTrigger("WalkR");
    }

     
        else if (Input.GetAxis("Vertical") < 0){

        ani.SetTrigger("WalkR");
        ani.ResetTrigger("Walk");
        ani.ResetTrigger("Idle");

     }

     else {
        ani.SetTrigger("Idle");
        ani.ResetTrigger("Walk");
        ani.ResetTrigger("WalkR");
     }
     

     

    }
}
