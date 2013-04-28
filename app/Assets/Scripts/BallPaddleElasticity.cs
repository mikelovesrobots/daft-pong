using UnityEngine;
using System.Collections;

public class BallPaddleElasticity : MonoBehaviour {
    private const float FORCE = 20f;
    private const float X_FORCE_DAMPENING = 0.5f;
    private const string PADDLE_TAG = "Paddle";

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.gameObject.tag == PADDLE_TAG) {
            var force = Force(collisionInfo.transform.position);
            rigidbody.AddForce(force);
        }
    }

    private Vector3 Force(Vector3 otherPosition) {
        return Direction(otherPosition) * FORCE;
    }

    private Vector3 Direction(Vector3 otherPosition) {
        var delta = transform.position - otherPosition;
        delta.x *= X_FORCE_DAMPENING;
        return delta.normalized;
    }
}
