using System.Collections;
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
    public void SilentDie()
    {
        LivingEnemyCount--; 
        Destroy(gameObject);
        //giảm số lượng enemy nhưng không gọi âm thanh hay hiệu ứng chết 
    }
}
