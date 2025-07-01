using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    public Vector3 bulletOffset;
    public GameObject bulletPrefab;
    public float shootingInterval;
    private float lastBulletTime;
   
    // Start is called before the first frame update
    
    void Update()
    {
        

        if (Input.GetMouseButton(0))// nhận lần bấm con chuột 
        {
            UpdateFiring();
        }
      
    }
    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)// kiểm tra thời gian để bắn viên đạn tiếp theo
        {
            ShootBullet();// tạo ra viên đạn mới 
            lastBulletTime = Time.time;// cập nhập thời gian bắn 

        }
    }
    private void ShootBullet()
    {
         var bullet = Instantiate(bulletPrefab, transform.position+bulletOffset, transform.rotation);
        //tạo ra bản sao của 1 viên đạn
    }

}
