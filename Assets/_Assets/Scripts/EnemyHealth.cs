using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
        if (collision.CompareTag("Bullet"))// chỉ cần đúng tag là dùng bên nào cũng được 
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    private void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        //tạo 1 bản sao của hiệu ứng nổ 
        Destroy(explosion, 1);// xoá hiệu ứng sau 1s
        Destroy(gameObject);
    }
    
}
