using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour 
{
    
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;
    public System.Action onDead; // Action: Delegate không có tham số, trả về void

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
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1f);
        Destroy(gameObject);
        onDead?.Invoke(); // ?. là toán tử kiểm tra xem onDead có khác null không trước khi gọi Invoke
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
