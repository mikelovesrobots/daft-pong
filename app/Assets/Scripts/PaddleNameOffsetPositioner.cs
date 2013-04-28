using UnityEngine;
using System.Collections;

public class PaddleNameOffsetPositioner : MonoBehaviour {   
    private const float LEFT = -1f;
    private const float RIGHT = 1f;

    void Start() {
        var x = LEFT;
        if (transform.position.x < 0) {
            x = RIGHT;
        }
        var position = transform.localPosition;
        position.x = x;
        transform.localPosition = position;
    }
}
