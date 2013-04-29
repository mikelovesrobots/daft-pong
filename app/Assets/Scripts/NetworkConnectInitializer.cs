using UnityEngine;
using System.Collections;

public class NetworkConnectInitializer : MonoBehaviour {
    public NetworkConnectMessageSequencer NetworkConnectMessageSequencer;

    void Start () {
        NetworkConnectMessageSequencer.Sequence();
    }
}
