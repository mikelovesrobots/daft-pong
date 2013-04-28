using UnityEngine;
using System.Collections;

public class BallFinder : MonoBehaviour {
    private const string BALL_TAG = "Ball";
    public GameObject SurrogateBall;
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

    public void RegisterBall(GameObject ball) {
        this.ball = ball;
    }

    public GameObject Find() {
        if (ball == null) {
            ball = GameObject.FindWithTag(BALL_TAG);
        }
        if (ball == null) {
            ball = SurrogateBall;
        }
        return ball;
    }
}
