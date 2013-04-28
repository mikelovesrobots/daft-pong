using UnityEngine;
using System.Collections;

public class BallCreateAction : ActionBase {
    public override void Act() {
        BallFactory.Create();
    }
}
