using UnityEngine;
using System.Collections;

public class PaddleAiAfkController : PaddleAi {
    private const float MIN_DRIFT = 0.0001f;
    private const float MAX_DRIFT = 0.0003f;

    private float drift = 0f; 

    void Start() {
        drift = Random.Range(MIN_DRIFT, MAX_DRIFT);
    }

    public override void Tick() {
        var position = transform.position;
        position.y += drift;
        transform.position = position;
    }
}
