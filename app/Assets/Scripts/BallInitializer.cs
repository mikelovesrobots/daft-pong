using UnityEngine;
using System.Collections;

public class BallInitializer : MonoBehaviour {
    public BallTosser BallTosser;

    public void Initialize() {
        BallTosser.Initialize();
    }
}
