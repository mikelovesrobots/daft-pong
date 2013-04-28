using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
    public const string TITLE = "Title";
    public const string PLAYER_SELECTION = "PlayerSelection";
    public const string GAME = "Game";
    public const string SCORE_RESULTS = "ScoreResults";

    public static void Title() {
        GoTo(TITLE);
    }

    public static void PlayerSelection() {
        GoTo(PLAYER_SELECTION);
    }

    public static void Game() {
        GoTo(GAME);
    }

    public static void ScoreResults() {
        GoTo(SCORE_RESULTS);
    }

    private static void GoTo(string name) {
        SceneTransition.Instance.TransitionTo(name);
    }
}
