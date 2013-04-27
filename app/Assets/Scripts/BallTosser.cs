using UnityEngine;
using System.Collections;

public class BallTosser : MonoBehaviour {
    private const float FORCE_MULTIPLIER = 50f;

    void Start() {
        rigidbody.AddForce(RandomForce);
    }

    private Vector3 RandomForce {
        get { return ((Vector3) Random.insideUnitCircle).normalized * FORCE_MULTIPLIER; }
    }
}
