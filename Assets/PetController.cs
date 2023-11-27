using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    private Character player;
    public float followDistance = 2f;
    public float moveSpeed = 3f;

    [HideInInspector]
    public StatusBar playerHealthBar;

    void Update()
    {
        FollowPlayer();
        
    }

    public void SetPlayer(Character player)
    {
        this.player = player;
        playerHealthBar = player.GetComponent<StatusBar>();
    }

    void FollowPlayer()
    {
        Vector3 targetPosition = player.transform.position - new Vector3(followDistance, 0f, 0f);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    void HealPlayer()
    {
        if (player.currentHp < player.maxHp)
        {
            player.currentHp = Mathf.Min(player.maxHp, player.currentHp + player.healAmount);
            playerHealthBar.SetState(player.currentHp,player.maxHp);
        }
    }

    
}


