using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3D : MonoBehaviour
{
    // Để 'private' để Unity không bắt bạn phải kéo thả thủ công nữa
    private CharacterController controller; 
    public float speed = 8.0f; // Tăng lên 8 để leo dốc khỏe hơn

    void Start()
    {
        controller = GetComponent<CharacterController>();

        if (controller == null)
        {
            Debug.LogError("Bạn chưa Add Component 'Character Controller' cho đối tượng này!");
        }
    }

    void Update()
    {
        if (controller == null) return;

        // Lấy dữ liệu di chuyển từ bàn phím
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Tính toán hướng di chuyển dựa trên hướng của nhân vật
        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;

        // SimpleMove() tự động xử lý trọng lực (Gravity)
        // Nhân vật sẽ tự bước lên bậc thang dựa vào Step Offset đã chỉnh ở Inspector
        controller.SimpleMove(move * speed);
    }
}