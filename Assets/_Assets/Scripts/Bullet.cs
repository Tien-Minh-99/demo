using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public int damege;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;// tạo ra vị trí mới và gán vị trí hiện tại cho vị trí mới ( vị trí mới = vị trí hiên tại ) 
        newPosition.y += Time.deltaTime * flySpeed;// delta x = vận tốc (V) * thời gian (T)
        transform.position = newPosition;// cập nhập lại vị trí (vị trí hiện tại = vị trí mới )
        if (transform.position.y > 6)
        {
            Destroy(gameObject);// xoá đạn khi nó bay ra khỏi màn hình 
        }
    }
    private void OnTriggerEnter2D(Collider2D col)// hàm đặc biệt (event function) đuọc gọi khi 
        //một collider2d đi vào vùng trigger của object
    {
        var enemy = col.GetComponent<EnemyHealth>();// kiểm tra xem col mà viên đạn vừa chạm vào có component EnemyHealth không 
        if (enemy != null)// kiểm tra có đúng là 1 enemy không 
        {
            enemy.TakeDamege(damege);// gọi hàm TakeDamege của enemy dẻ trừ máu theo lượng damege
        }
        Destroy(gameObject);
        //if (col.CompareTag("Enemy"))// kiểm tra xem object cso đúng tag không 
        //{
        //    Destroy(col.gameObject);// xoá enemy
        //    Destroy(gameObject); // xoá viên đạn 
        //}
        
    }
}
