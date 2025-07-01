using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour 
{
    
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;

    // Start is called before the first frame update
    void Start()
    {
        healthPoint = defaultHealthPoint;// số máu hiện tại bằng số máu ban đầu 
    }
    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Die();
    //}
    protected virtual void Die()// chuyển Die qua class health để dùng lại nhiều lần 
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
            
        }
        Destroy(gameObject);
    }
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0)
        {
            return;// nếu đã chết thì bỏ qua 
        }
        healthPoint -= damage;// trừ máu 
        if (healthPoint <= 0)
        {
            Die();// nếu máu giảm còn 0 thì Die
        }
        Debug.Log("HP còn lại: " + healthPoint);
    }
  
 
}
