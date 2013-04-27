using UnityEngine;
using System.Collections;

public class BallTosser : MonoBehaviour {
    private const float FORCE_MULTIPLIER = 100f;
    private const float MIN_X_SPEED = 0.5f;

    void Start() {
        rigidbody.AddForce(TossForce);
    }

    private Vector3 TossForce {
        get { 
            var vector = (Vector3) Random.insideUnitCircle;
            if (vector.x > 0) {
                vector.x += MIN_X_SPEED;
            } else {
                vector.x -= MIN_X_SPEED;
            }
            return vector.normalized * FORCE_MULTIPLIER;
        }
    }
}
