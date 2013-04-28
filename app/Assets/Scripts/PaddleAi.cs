using UnityEngine;
using System.Collections;

public class PaddleAi : MonoBehaviour {
    public virtual void Tick() {

    }

    public Transform Ball {
        get { return BallFinder.Instance.Find().transform; }
    }
}
