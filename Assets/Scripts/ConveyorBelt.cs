using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour {
    public float speed = 3f;
    void OnCollisionStay(Collision collision) {
        // Đẩy mọi thứ đứng trên nó đi theo hướng phải
        collision.gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}