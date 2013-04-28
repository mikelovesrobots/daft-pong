using UnityEngine;
using System.Collections;

public class ScoreResultsTitleRenderer : MonoBehaviour {
    private const float WIDTH = 512f;
    private const float HEIGHT = 64f;
    private const string WIN_TITLE = "WINNER IS YOU!";
    private const string LOSE_TITLE = "LOSER IS YOU!";
    private string label;
    private Color color;
    public GUISkin GuiSkin;
    public Color WinColor;
    public Color LoseColor;

    void OnGUI() {
        GUI.skin = GuiSkin;
        GUI.color = color;
        GUI.Label(Rect, label);
    }

    public void Initialize(bool playerWon) {
        AssignTitle(playerWon);
    }

    private void AssignTitle(bool playerWon) {
        if (playerWon) {
            label = WIN_TITLE;
            color = WinColor;
        } else {
            label = LOSE_TITLE;
            color = LoseColor;
        }
    }

    private Rect Rect {
        get {
            var anchor = TransformToGuiFinder.Find(transform);
            return new Rect(anchor.x - WIDTH / 2, anchor.y - HEIGHT / 2, WIDTH, HEIGHT);
        }
    }
}
