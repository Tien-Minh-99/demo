using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float shootingInterval;
    private float lastBulletTime;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))// nhận lần bấm con chuột 
        {
            if(Time.time-lastBulletTime> shootingInterval)// kiểm tra thời gian để bắn viên đạn tiếp theo
            {
                ShootBullet();// tạo ra viên đạn mới 
                lastBulletTime = Time.time;// cập nhập vị trí viên đạn 

            }
        }
    }
    private void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        //tạo ra bản sao của 1 viên đạn
    }

}
