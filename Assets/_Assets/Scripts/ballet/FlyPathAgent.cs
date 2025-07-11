using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    public float flySpeed;
    private int nextIndex = 1;

    
   

    // Update is called once per frame
    void Update()
    {
        if (flyPath == null)
        {
            return;
        }
        if (nextIndex >= flyPath.waypoints.Length)
        {
            //nếu enemy vẫn còn máu ( không bị bắn chết ) gọi Die() để cập nhập số lượng 
            var health = GetComponent<EnemyHealth>();
            if(health!=null && health.healthPoint > 0)
            {
                health.SilentDie();// ép enemy chết bằng cách trừ hết máu 

            }
            Destroy(gameObject);
            return;
        }
        if(transform.position!= flyPath[nextIndex])
        {
            FlyToNextWaypoint();
            LookAt(flyPath[nextIndex]);
        }
        else
        {
            nextIndex++;
        }
    }
    private void FlyToNextWaypoint()// bay đến điểm dừng tiếp theo 
    {
        transform.position = Vector3.MoveTowards(transform.position, flyPath[nextIndex],
            flySpeed * Time.deltaTime);//Move Towards: di chuyển về phía 
    }
    private void LookAt(Vector2 destitination)
    {
        Vector2 position = transform.position;
        var lookDirection = destitination - position;
        if (lookDirection.magnitude < 0.01f)
        {
            return;
        }
        var angle = Vector2.SignedAngle(Vector3.down, lookDirection);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
