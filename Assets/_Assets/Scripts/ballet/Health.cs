using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour 
{
    
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    public System.Action onDead; // Action: Delegate không có tham số, trả về void
    public System.Action onHeathChanged;// sự kiện để thông báo cho tất cả những class chưa health có sự thay đổi 
    public int healthPoint;

    // Start is called before the first frame update
    void Start()
    {
        healthPoint = defaultHealthPoint;// số máu hiện tại bằng số máu ban đầu
        onHeathChanged?.Invoke();
    }
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
        onHeathChanged?.Invoke();
        if (healthPoint <= 0)
        {
            Die();// nếu máu giảm còn 0 thì Die
        }
        Debug.Log("HP còn lại: " + healthPoint);
    }
  // toán tử ?. sẽ kiểm tra xem phần được gọi có khác null không rồi sẽ gọi hàm invoke
 //invoke là để gọi sự kiện phía trước nó
}
