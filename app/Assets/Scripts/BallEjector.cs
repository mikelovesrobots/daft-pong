using UnityEngine;
using System.Collections;

public class BallEjector : MonoBehaviour {
    public BallCreateAction BallCreateAction;
    private static BallEjector instance;
    public static BallEjector Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/BallEjector").GetComponent<BallEjector>();
            }

            return instance;
        }
    }

    public void EjectBall(GameObject ball) {
        Destroy(ball);
        BallCreateAction.Act();
    }
}
