using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public GameObject Roadsection;

    public SectionTrigger(GameObject roadsection)
    {
        Roadsection = roadsection;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("RoadTrigger"))
        {
            Instantiate(Roadsection, new Vector3(0, 0, -36), Quaternion.identity);
        }
    }
}
