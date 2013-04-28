using UnityEngine;
using System.Collections;

public class BallFinder : MonoBehaviour {
    private GameObject ball;
    private static BallFinder instance;

    public static BallFinder Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/BallFinder").GetComponent<BallFinder>();
            }

            return instance;
        }
    }

    public GameObject Find() {
        if (ball == null) {
            ball = GameObject.Find("Ball");
        }
        return ball;
    }
}
