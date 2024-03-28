using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force = 20f;
    public Rigidbody rb;
    bool onFloor = false;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true) 
        {
            rb.AddForce(Vector3.up * 500);
            onFloor = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
        }
    }
}
