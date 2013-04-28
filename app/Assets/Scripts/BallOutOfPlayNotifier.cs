using UnityEngine;
using System.Collections;

public class BallOutOfPlayNotifier : MonoBehaviour {
    private const string PADDLE_TAG = "Paddle";
    private const float WAIT_TIME = 10f;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.gameObject.tag == PADDLE_TAG) {
            StopAllCoroutines();
            StartCoroutine(WaitAndEjectBall());
        }
    }

    private IEnumerator WaitAndEjectBall() {
        yield return new WaitForSeconds(WAIT_TIME);
        BallEjector.Instance.EjectBall(gameObject);
    }
}
