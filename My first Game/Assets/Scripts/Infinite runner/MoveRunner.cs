using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRunner : MonoBehaviour
{
    public float initialSpeed = 2f; // Initial speed
    public float speedIncreaseRate = 0.1f; // Rate at which speed increases per second
    private float currentSpeed; // Current speed

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = initialSpeed;
        StartCoroutine(IncreaseSpeedOverTime());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
    }

    IEnumerator IncreaseSpeedOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); // Adjust this delay as needed
            currentSpeed += speedIncreaseRate;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy")) 
        {
            Destroy(gameObject);
        }
    }
}
