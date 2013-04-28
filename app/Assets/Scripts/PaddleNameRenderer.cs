using UnityEngine;
using System.Collections;

public class PaddleNameRenderer : MonoBehaviour {
    private const float WIDTH = 650;
    private const float HEIGHT = 80;
    public GUISkin BoldGuiSkin;
    public GUISkin NormalGuiSkin;
    private GUISkin guiSkin;
    private string playerName;
    private Color color;

    public void Initialize(string playerName, Color color, bool isBold) {
        this.color = color;
        this.playerName = playerName;
        if (isBold) {
            this.guiSkin = BoldGuiSkin;
        } else {
            this.guiSkin = NormalGuiSkin;
        }

    }

    void OnGUI () {
        GUI.skin = guiSkin;
        GUI.color = color;
        GUI.Label(Rect, playerName);
    }

    private Rect Rect {
        get {
            var anchor = TransformToGuiFinder.Find(transform);
            return new Rect(anchor.x - WIDTH / 2, anchor.y - HEIGHT / 2, WIDTH, HEIGHT);
        }
    }
}
