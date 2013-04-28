using UnityEngine;
using System.Collections;

public class BallDestroyAction : ActionBase {
    public override void Act() {
        Destroy(BallFinder.Instance.Find());
    }
}
