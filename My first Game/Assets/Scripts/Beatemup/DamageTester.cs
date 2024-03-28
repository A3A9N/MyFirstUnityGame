using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public GameObject player;
    private Attributemanager playeratm;
    public Attributemanager enemyatm;

    private void Start()
    {
        playeratm = player.GetComponent<Attributemanager>();
    }
    private void Update()
    {
        //deal player damage to enemy
        if (Input.GetKeyDown(KeyCode.J))
        {

            Debug.Log("J");
            playeratm.Dealdamage(enemyatm.gameObject);
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            enemyatm.Dealdamage(playeratm.gameObject);
        }
    }
}
