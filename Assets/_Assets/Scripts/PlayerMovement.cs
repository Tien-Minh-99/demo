using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //var: thay vì viết kiểu dữ liệu thì var sẽ lấy kết quả trả về làm kiểu dữ liệu 
        //screen là màn hình 
        // World là màn hình scene
        worldPoint.z = 0;
        transform.position = worldPoint;
    }
}
