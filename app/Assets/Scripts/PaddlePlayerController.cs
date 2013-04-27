using UnityEngine;
using System.Collections;

public class PaddlePlayerController : MonoBehaviour {
    private const float DISTANCE_FROM_CAMERA = 10f;

    void FixedUpdate() {
        UpdateYPosition();
    }

    private void UpdateYPosition() {
        var currentPosition = transform.position;
        currentPosition.y = MousePosition.y;
        transform.position = currentPosition;
    }

    private Vector3 MousePosition {
        get {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = DISTANCE_FROM_CAMERA;
            var worldPoint = Camera.main.ScreenToWorldPoint(mousePosition);
            return worldPoint;
        }
    }
}
