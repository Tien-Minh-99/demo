using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour 
{
    
    public GameObject explosionPrefab;
    public int defauHealthPoint;
    private int healthPoint;

    // Start is called before the first frame update
    void Start()
    {
        healthPoint = defauHealthPoint;// số máu hiện tại bằng số máu ban đầu 
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
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
    public void TakeDamege(int damege)
    {
        {
            Debug.Log("befor: hp = " + healthPoint);
            if (healthPoint <= 0)
            {
                Debug.Log("after damege: hp = " + healthPoint);
                return;// nếu đã chết thì bỏ qua 
            }
            healthPoint -= damege;// trừ máu 
            if (healthPoint <= 0)
            {
                Debug.Log("die: hp<=0");
                Die();// nếu máu giảm còn 0 thì Die
            }
        }
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
