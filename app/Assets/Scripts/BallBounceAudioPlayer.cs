using UnityEngine;
using System.Collections;

public class BallBounceAudioPlayer : MonoBehaviour {
    void OnCollisionEnter() {
        AudioPlayer.Instance.Bounce();
    }
}
