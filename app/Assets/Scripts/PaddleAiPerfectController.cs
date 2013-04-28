using UnityEngine;
using System.Collections;

public class PaddleAiPerfectController : PaddleAi {
    private const float MIN_SPEED = 0.01f;
    private const float MAX_SPEED = 0.05f;
    private float speed = 0f;

    void Start() {
        speed = Random.Range(MIN_SPEED, MAX_SPEED);
    }

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
            var acceptableDelta = Mathf.Clamp(delta, -speed, speed);
            return transform.position.y + acceptableDelta;
        }
    }

}
