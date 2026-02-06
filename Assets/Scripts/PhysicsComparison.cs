using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsComparison : MonoBehaviour
{
    // 1. Chạy khi va chạm vật lý (IsTrigger = false)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION: Chạm vào vật cứng " + collision.gameObject.name);
        // Khi chạm vào vật cứng, vận tốc sẽ bị thay đổi (nảy ra hoặc dừng lại)
    }

    // 2. Chạy khi đi xuyên qua (IsTrigger = true)
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER: Đi xuyên qua vùng " + other.gameObject.name);
        // Không ảnh hưởng đến chuyển động, quả bóng vẫn giữ nguyên tốc độ
    }
}