using UnityEngine;
using System.Collections;

public class PaddleNameRenderer : MonoBehaviour {
    private const float WIDTH = 650;
    private const float HEIGHT = 80;
    public GUISkin GuiSkin;
    private string playerName;

    public void Initialize(string playerName) {
        this.playerName = playerName;
    }

    void OnGUI () {
        GUI.skin = GuiSkin;
        GUI.Label(Rect, playerName);
    }

    private Rect Rect {
        get {
            var anchor = TransformToGuiFinder.Find(transform);
            return new Rect(anchor.x - WIDTH / 2, anchor.y - HEIGHT / 2, WIDTH, HEIGHT);
        }
    }
}
