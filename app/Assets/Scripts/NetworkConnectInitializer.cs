using UnityEngine;
using System.Collections;

public class NetworkConnectInitializer : MonoBehaviour {
    public NetworkConnectMessageSequencer NetworkConnectMessageSequencer;
    public NetworkConnectTipSequencer NetworkConnectTipSequencer;

    void Start () {
        NetworkConnectMessageSequencer.Sequence();
        NetworkConnectTipSequencer.Sequence();
    }
}
