using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float maxHp = 100;
    public float currentHp = 100;
    public float armor = 0;
    public float healAmount = 20;
    public float healInterval = 3;

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

    public void TakeDamage(float damage)
    {
        ApplyArmor(ref damage); 
        currentHp -= damage;

        if (currentHp <= 0 )
        {
            Debug.Log("Character is dead");
        }
        hpBar.SetState(currentHp, maxHp);
    }

    private void ApplyArmor(ref float damage)
    {
        damage -= armor;
        if (damage < 0) { damage = 0; }
    }

    public void Heal(float amount)
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
