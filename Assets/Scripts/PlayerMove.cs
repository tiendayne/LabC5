using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMove : MonoBehaviour {
    public CharacterController controller;
    public float speed = 5f;
    private float gravity = -9.81f;
    private float verticalVelocity;

    void Update() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        // Trọng lực đơn giản
        if (controller.isGrounded && verticalVelocity < 0) verticalVelocity = -2f;
        verticalVelocity += gravity * Time.deltaTime;
        
        move.y = verticalVelocity;
        controller.Move(move * speed * Time.deltaTime);
    }

    // Hàm để JumpPad gọi
    public void Bounce(float force) {
        verticalVelocity = force;
    }
}