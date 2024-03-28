using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    [SerializeField]private float speed = 50f;

    [SerializeField]private float speedR = 50f;
    [SerializeField]private float rotSpeed = 50f;

    private Rigidbody rb;
    float rottt;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionUpdate = transform.position + Input.GetAxis("Horizontal") * transform.forward * speed * Time.deltaTime;
        transform.position = positionUpdate;
        Vector3 positionUpdateSide = transform.position + Input.GetAxis("Vertical") * transform.right * speedR * Time.deltaTime;
        transform.position = positionUpdateSide;
        //transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));
        
        if(Input.GetAxis("Horizontal") < 1){

            transform.Rotate(0,180,0);
        };
        
        
        
    }
}
