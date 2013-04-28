using UnityEngine;
using System.Collections;

public class GoalActionDelegate : ActionBase {
    public override void Act() {
        GoalAction.Instance.Act();
    }
}
