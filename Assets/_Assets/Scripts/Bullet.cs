using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
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
    }
}
