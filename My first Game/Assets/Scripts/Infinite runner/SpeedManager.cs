using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public float initialSpeed = 2f; // Initial speed
    public float speedIncreaseRate = 0.1f; // Rate at which speed increases per second
    private float currentSpeed; // Current speed

    private static SpeedManager instance;

    public static SpeedManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SpeedManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(SpeedManager).Name;
                    instance = obj.AddComponent<SpeedManager>();
                }
            }
            return instance;
        }
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        currentSpeed = initialSpeed;
        StartCoroutine(IncreaseSpeedOverTime());
    }

    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }

    // Coroutine to gradually increase speed over time
    IEnumerator IncreaseSpeedOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); // Adjust this delay as needed
            currentSpeed += speedIncreaseRate;
        }
    }
}
