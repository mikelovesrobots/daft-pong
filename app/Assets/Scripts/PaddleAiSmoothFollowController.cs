using UnityEngine;
using System.Collections;

public class PaddleAiSmoothFollowController : MonoBehaviour {
    public Transform Ball;
    private Vector3 lastPosition;

    void FixedUpdate() {
        UpdateYPosition();
    }

    private void UpdateYPosition() {
        lastPosition = transform.position;

        var wantedPosition = transform.position;
        wantedPosition.y = Ball.position.y;

        var meldedPosition = ((lastPosition * 20) + wantedPosition) / 21;
        transform.position = meldedPosition;
    }
}
