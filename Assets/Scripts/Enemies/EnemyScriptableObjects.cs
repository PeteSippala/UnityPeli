using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName ="EnemyScriptableObjects", menuName ="ScriptableObjects/Enemy")]

public class EnemyScriptable  : ScriptableObject
{
    // base stats for enemies
    public float moveSpeed;
    public float maxHealth;
    public float damage;

}
