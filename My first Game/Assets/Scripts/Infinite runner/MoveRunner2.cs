using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRunner2 : MonoBehaviour
{
    private float currentSpeed; // Current speed

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = SpeedManager.Instance.GetCurrentSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, currentSpeed) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
