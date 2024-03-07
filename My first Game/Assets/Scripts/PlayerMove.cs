using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody myBody;
    public float walk_Speed = 3f;
    public float z_Speed = 1.5f;

    private float rotation_Y = -90f;
    private float rotation_Speed = 15f;



    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DetectMovement()
    {
        myBody.velocity = new Vector3
        (
            Input.GetAxisRaw("horizontal") * (-walk_Speed),
            myBody.velocity.y,
            Input.GetAxisRaw("Vertical") * (-z_Speed)
        );
    }
}
