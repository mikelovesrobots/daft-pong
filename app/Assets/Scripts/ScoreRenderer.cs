using UnityEngine;
using System.Collections;

public class ScoreRenderer : MonoBehaviour {
    private const float WIDTH = 200;
    private const float HEIGHT = 80;
    private int score = 0;
    public Color color;
    public GUISkin GuiSkin;

    public void Render(int score) {
        this.score = score;
    }

    void OnGUI () {
        GUI.skin = GuiSkin;
        GUI.color = color;
        GUI.Label(Rect, score.ToString());
    }

    private Rect Rect {
        get {
            var anchor = TransformToGuiFinder.Find(transform);
            return new Rect(anchor.x - WIDTH / 2, anchor.y - HEIGHT / 2, WIDTH, HEIGHT);
        }
    }
}
