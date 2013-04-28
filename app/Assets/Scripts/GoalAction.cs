using UnityEngine;
using System.Collections;

public class GoalAction : ActionBase {
    private const float FADE_OUT_DELAY = 3f;
    public GameObject Goal;
    public BallDestroyAction BallDestroyAction;
    public BallCreateAction BallCreateAction;
    public GoalNameRenderer GoalNameRenderer;

    public override void Act() {
        BallDestroyAction.Act();
        RevealGoalLabel();
        AudioPlayer.Instance.Goal();
    }

    private void RevealGoalLabel() {
        FadeAnimator.Instance.FadeIn(Goal, 0f);
        FadeAnimator.Instance.FadeOut(Goal, FADE_OUT_DELAY, () => BallCreateAction.Act());
        GoalNameRenderer.Render(LastShooter);
    }

    private string LastShooter {
        get {
            return GameHistory.Instance.LastShooter;
        }
    }
}
