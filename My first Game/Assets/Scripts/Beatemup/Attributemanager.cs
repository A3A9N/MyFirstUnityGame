using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributemanager : MonoBehaviour
{
    public int health;
    public int attack;

    public void Takedamage(int amount)
    {
        health -= amount;
    }

    public void Dealdamage(GameObject target)
    {

        Debug.Log("deal");
        var atm = target.GetComponent<Attributemanager>();
        if(atm != null)
        {
            atm.Takedamage(attack);
        }
    }
}
