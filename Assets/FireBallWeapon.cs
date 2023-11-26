using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallWeapon : MonoBehaviour
{
    [SerializeField] float timeToAttack;
    float timer;

    movement playerMove;

    [SerializeField] GameObject fireballPrefab;

    private void Awake()
    {
        playerMove = GetComponentInParent<movement>();
    }


    private void Update()
    {
        if (timer < timeToAttack)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        spawnFireball();
    }

    private void spawnFireball()
    {
        GameObject fireBall = Instantiate(fireballPrefab);
        fireBall.transform.position = transform.position;
        fireBall.GetComponent<FireBallProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f);
    }
}
