using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActtack : MonoBehaviour
{
    public EnemyHealth health;
    public int damege;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();// tìm xem đối tượng va chạm có component PlayerHealth không 
        if (playerHealth != null)
        {
            playerHealth.TakeDamege(damege);// gây sát thương cho người chơi 
           
            health.TakeDamege(1000); // gây sát thương cực lớn lên enemy 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
