using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp = 100;
    public int armor = 0;
    public int healAmount = 20;
    public int healInterval = 3;

    public GameObject petPrefab;
    private GameObject petInstance;
    [SerializeField] StatusBar hpBar;

    [HideInInspector] public Level level;
    [HideInInspector] public Coins coins;

    private void Awake()
    {
        level = GetComponent<Level>();
        coins = GetComponent<Coins>();
    }

    private void Start()
    {
        hpBar.SetState(currentHp, maxHp);
        SpawnPet();
        InvokeRepeating("HealPlayer", healInterval, healInterval);
    }

    public void TakeDamage(int damage)
    {
        ApplyArmor(ref damage); 
        currentHp -= damage;

        if (currentHp <= 0 )
        {
            Debug.Log("Character is dead");
        }
        hpBar.SetState(currentHp, maxHp);
    }

    private void ApplyArmor(ref int damage)
    {
        damage -= armor;
        if (damage < 0) { damage = 0; }
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
    void HealPlayer()
    {
        if (currentHp < maxHp)
        {
            currentHp = Mathf.Min(maxHp, currentHp + healAmount);
            hpBar.SetState(currentHp,maxHp);
        }
    }

    void SpawnPet()
    {
        petInstance = Instantiate(petPrefab, transform.position - new Vector3(1f, 0f, 0f), Quaternion.identity);
        petInstance.GetComponent<PetController>().SetPlayer(this);
    }
}
