using UnityEngine;
using System.Collections;

public class PaddleAiPerfectController : MonoBehaviour {
    public Transform Ball;

    void FixedUpdate() {
        UpdateYPosition();
    }

    private void UpdateYPosition() {
        var wantedPosition = transform.position;
        wantedPosition.y = Ball.position.y;
        transform.position = wantedPosition;
    }
}
