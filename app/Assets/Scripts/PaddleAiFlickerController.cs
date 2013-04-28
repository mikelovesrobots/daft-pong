using UnityEngine;
using System.Collections;

public class PaddleAiFlickerController : PaddleAi {
    private const float ARRIVAL_DISTANCE = 0.1f;
    private const float MAX_Y = 3f;
    private const float MIN_VELOCITY = 0.001f;
    private const float MAX_VELOCITY = 0.05f;
    private float targetY = 0f;
    private float velocity = 0f;

    void Start() {
        velocity = Random.Range(MIN_VELOCITY, MAX_VELOCITY);
    }

    public override void Tick() {
        if (Mathf.Abs(transform.position.y - targetY) < ARRIVAL_DISTANCE) {
            ChangeTarget();
        }
        var position = transform.position;
        position.y += Drift;
        transform.position = position;
    }

    private void ChangeTarget() {
        targetY = Random.Range(-MAX_Y, MAX_Y);
    }

    private float Drift {
        get {
            if (transform.position.y < targetY) {
                return velocity;
            } 
            return -velocity;
        }
    }
}
