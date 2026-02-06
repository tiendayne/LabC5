using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsLog : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Chạm vật lý với: " + collision.gameObject.name);
    }


    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Đã đi vào vùng Trigger: " + other.gameObject.name);
    }
}