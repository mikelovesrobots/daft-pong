using UnityEngine;
using System.Collections;

public class GoalAction : ActionBase {
    private const float FADE_OUT_DELAY = 3f;
    public GameObject Goal;
    public BallDestroyAction BallDestroyAction;
    public BallCreateAction BallCreateAction;
    private static GoalAction instance;
    public static GoalAction Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/GoalAction").GetComponent<GoalAction>();
            }

            return instance;
        }
    }
    public override void Act() {
        BallDestroyAction.Act();
        RevealGoalLabel();
        AudioPlayer.Instance.Goal();
    }

    private void RevealGoalLabel() {
        FadeAnimator.Instance.FadeIn(Goal, 0f);
        FadeAnimator.Instance.FadeOut(Goal, FADE_OUT_DELAY, () => BallCreateAction.Act());
    }
}
