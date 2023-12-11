using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [HideInInspector]
    public CharacterScriptableObject characterData;
    [HideInInspector]
    public float currrentHealth;
    [HideInInspector]
    public float currentRecovery;
    [HideInInspector]
    public float currentMoveSpeed;
    [HideInInspector]
    public float currentPower;
    [HideInInspector]
    public float currentProjectileSpeed;
    void Awake()
    {
        //Assigning process
        currrentHealth = characterData.MaxHealth;
        currentRecovery = characterData.Recovery;
        currentMoveSpeed = characterData.MoveSpeed;
        currentPower = characterData.Power;
        currentProjectileSpeed = characterData.ProjectileSpeed;
    }
}


