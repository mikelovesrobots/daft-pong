using UnityEngine;
using System.Collections;

public class PaddleAiPerfectController : PaddleAi {
    private const float MAX_DELTA = 0.05f;

    public override void Tick() {
        UpdateYPosition();
    }

    private void UpdateYPosition() {
        var position = transform.position;
        position.y = AcceptableYTowardsBall;
        transform.position = position;
    }

    private float AcceptableYTowardsBall {
        get {
            var delta = Ball.position.y - transform.position.y;
            var acceptableDelta = Mathf.Clamp(delta, -MAX_DELTA, MAX_DELTA);
            return transform.position.y + acceptableDelta;
        }
    }

}
