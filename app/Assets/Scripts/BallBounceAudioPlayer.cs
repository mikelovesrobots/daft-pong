using UnityEngine;
using System.Collections;

public class BallBounceAudioPlayer : MonoBehaviour {
    private const float WAIT_TIME = 0.02f;
    private bool canPlay = true;

    void OnCollisionEnter() {
        if (canPlay) {
            AudioPlayer.Instance.Bounce();
            canPlay = false;
            StartCoroutine(WaitThenEnablePlaying());
        }
    }

    private IEnumerator WaitThenEnablePlaying() {
        yield return new WaitForSeconds(WAIT_TIME);
        canPlay = true;
    }
}
