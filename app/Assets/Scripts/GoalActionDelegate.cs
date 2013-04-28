using UnityEngine;
using System.Collections;

public class GoalActionDelegate : ActionBase {
    public override void Act() {
        Debug.Log("Goal action delegate");
        GoalAction.Instance.Act();
    }
}
