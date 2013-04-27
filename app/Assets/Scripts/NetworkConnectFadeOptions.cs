using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class NetworkConnectFadeOptions {
    public GameObject Target { get; private set; }
    public Action Callback { get; private set; }

    public NetworkConnectFadeOptions(GameObject target, Action callback) {
        this.Target = target;
        this.Callback = callback;
    }
}

