using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadScript : MonoBehaviour {
    public float bounceForce = 12f;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<PlayerMove>().Bounce(bounceForce);
            Debug.Log("Đã bắn Player!");
        }
    }
}