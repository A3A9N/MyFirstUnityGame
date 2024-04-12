using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic2 : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    private Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");
       // rb.velocity = rb.transform.forward * move;

        //rb.velocity = rb.transform.forward * move;
    
        Vector3 lastVel = rb.velocity;
        Vector3 newVel = rb.transform.forward * move;
        newVel.y = lastVel.y;
        rb.velocity = newVel;

        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));
    }
}
