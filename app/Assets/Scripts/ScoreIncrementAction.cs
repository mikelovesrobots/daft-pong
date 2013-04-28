using UnityEngine;
using System.Collections;

public class ScoreIncrementAction : ActionBase {
    public override void Act() {
        if (GoalScoredForRightSide) {
            ScoreKeeper.Instance.ScoreRight();
        } else {
            ScoreKeeper.Instance.ScoreLeft();
        }
    }

    private bool GoalScoredForRightSide {
        get {
            return transform.position.x < 0;
        }
    }
}
