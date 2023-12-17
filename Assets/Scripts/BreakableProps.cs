using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BreakAbleProps : MonoBehaviour
{
    public float health;

    public void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Kill();
        }
    }
    
    public void Kill()
    {
        Destroy(gameObject);
    }
}
