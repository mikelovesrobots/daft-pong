using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
    public const string TITLE = "Title";
    public const string PLAYER_SELECTION = "PlayerSelection";
    public const string GAME = "GAME";

    public static void Title() {
        GoTo(TITLE);
    }

    public static void PlayerSelection() {
        GoTo(PLAYER_SELECTION);
    }

    public static void Game() {
        GoTo(GAME);
    }

    private static void GoTo(string name) {
        SceneTransition.Instance.TransitionTo(name);
    }
}
