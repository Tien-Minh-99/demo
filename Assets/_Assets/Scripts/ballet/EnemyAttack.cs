using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();// tìm xem đối tượng va chạm có component PlayerHealth không 
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);// gây sát thương cho người chơi 
           
            health.TakeDamage(1000); // gây sát thương cực lớn lên enemy 
        }
    }

}
