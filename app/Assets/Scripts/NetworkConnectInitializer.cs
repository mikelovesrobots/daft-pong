using UnityEngine;
using System.Collections;

public class NetworkConnectInitializer : MonoBehaviour {
    public NetworkConnectMessageSequenceAnimator NetworkConnectMessageSequenceAnimator;

    void Start () {
        NetworkConnectMessageSequenceAnimator.Animate();
    }
}
