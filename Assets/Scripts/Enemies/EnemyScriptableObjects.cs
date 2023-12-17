using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName ="EnemyScriptableObjects", menuName ="ScriptableObjects/Enemy")]

public class EnemyScriptable  : ScriptableObject
{
    // base stats for enemies
    [SerializeField]
    float moveSpeed;
    public float MoveSpeed { get => moveSpeed; private set => moveSpeed = value; }
    [SerializeField]
    float maxHealth;
    public float MaxHealth { get => maxHealth; private set => maxHealth = value; }
    [SerializeField]
    float damage;
    public float Damage { get => damage; private set => damage = value; }

}
