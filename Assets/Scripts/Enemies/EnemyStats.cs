using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public EnemyScriptable enemyData;

    //Current stats
    float currentMoveSpeed;
    float currentHealth;
    float currentDamage;

    public float despawningDistance = 20f;
    Transform player;

    // Start is called before the first frame update
    private void Awake()
    {
        currentMoveSpeed = enemyData.moveSpeed;
        currentHealth = enemyData.maxHealth;
        currentDamage = enemyData.damage;
    }

    private void Start()
    {

        player = FindAnyObjectByType<PlayerStats>().transform;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, player.position) >= despawningDistance) 
        {
            ReturnEnemy();
        }
    }

    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;

        if(currentHealth <= 0) 
        {
            kill();
        }
    }

    public void kill()
    {
        EnemySpawner es = FindObjectOfType<EnemySpawner>();
        es.OnEnemyKilled();
        Destroy(gameObject);
    }


    void ReturnEnemy()
    {
        EnemySpawner es = FindObjectOfType<EnemySpawner>();
        transform.position = player.position + es.relativeSpawnPoints[Random.Range(0, es.relativeSpawnPoints.Count)].position;

    }
    
}
