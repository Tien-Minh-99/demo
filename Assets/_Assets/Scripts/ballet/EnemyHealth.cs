﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;
    private void Awake()
    {
        LivingEnemyCount++;
    }
    
    protected override void Die()
    {
        LivingEnemyCount--;
        base.Die();
        Debug.Log("enemy died");

    }

    //public GameObject explosionPrefab;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Die();
    //}
    //private void Die()
    //{
    //    var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
    //    //tạo 1 bản sao của hiệu ứng nổ 
    //    Destroy(explosion, 1);// xoá hiệu ứng sau 1s
    //    Destroy(gameObject);
    //}

}
