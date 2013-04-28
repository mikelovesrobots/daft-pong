using UnityEngine;
using System.Collections;

public class BallSpeedLimiter : MonoBehaviour {
    private const float SPEED_LIMIT = 15f;

    void FixedUpdate() {
        if (rigidbody.velocity.magnitude > SPEED_LIMIT) {
            rigidbody.velocity = rigidbody.velocity.normalized * SPEED_LIMIT;
            Debug.Log("Welcome to the dangerZONE");
        }
    }
}
