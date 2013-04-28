using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
    private const int SCORE_LIMIT = 20;
    public int LeftScore = 0;
    public int RightScore = 0;
    public ScoreRenderer LeftScoreRenderer;
    public ScoreRenderer RightScoreRenderer;
    public GoalAction GoalAction;

    private static ScoreKeeper instance;
    public static ScoreKeeper Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/ScoreKeeper").GetComponent<ScoreKeeper>();
            }

            return instance;
        }
    }

    public void ScoreLeft() {
        LeftScore++;
        LeftScoreRenderer.Render(LeftScore);
        GoalAction.Act();
        TryToEndGame();
    }

    public void ScoreRight() {
        RightScore++;
        RightScoreRenderer.Render(RightScore);
        GoalAction.Act();
        TryToEndGame();
    }

    private bool GameShouldEnd {
        get {
            return (LeftScore >= SCORE_LIMIT) || (RightScore >= SCORE_LIMIT);
        }
    }

    private void TryToEndGame() {
        if (GameShouldEnd) {
            EndGame();
        }
    }

    private void EndGame() {
        ScoreResultsOptions.PlayerWon = PlayerWon;
        LoadLevel.ScoreResults();
    }

    private bool PlayerWon {
        get { return RightScore > LeftScore; }
    }
}
