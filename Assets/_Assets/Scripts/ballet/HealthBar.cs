using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform mask;
    public Health health;

    private float originalWidth;
    // Start is called before the first frame update
    void Start()
    {
        originalWidth = mask.sizeDelta.x; // ghi nhớ chiều rộng 'x' của thanh máu 
        UpdateHealthValue();
        health.onHeathChanged += UpdateHealthValue; // cập nhập thanh máu mỗi khi có thay đổi 
    }

   private void UpdateHealthValue()
    {
        if (this == null || mask == null || health == null)
        {
            return;
        }
        float scale = (float)health.healthPoint / health.defaultHealthPoint;
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }
}
