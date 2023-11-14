using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp = 100;
    [SerializeField] StatusBar hpBar;

    [HideInInspector] public Level level;

    private void Awake()
    {
        level = GetComponent<Level>();
    }

    private void Start()
    {
        hpBar.SetState(currentHp, maxHp);
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;

        if (currentHp <= 0 )
        {
            Debug.Log("Character is dead");
        }
        hpBar.SetState(currentHp, maxHp);
    }

    public void Heal(int amount)
    {
        if(currentHp <= 0 ) { return; }

        currentHp += amount;
        if(currentHp > maxHp)
        {
            currentHp = maxHp;
        }

        hpBar.SetState(currentHp, maxHp);

    }
}
