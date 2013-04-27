using UnityEngine;
using System.Collections;

public class PlayerNameEditor : MonoBehaviour {
    private const float WIDTH = 650;
    private const float HEIGHT = 80;
    private const string CONTROL_NAME = "PlayerName";
    public GUISkin GuiSkin;
    public string PlayerName;

    void OnGUI () {
        GUI.skin = GuiSkin;

        GUI.SetNextControlName(CONTROL_NAME);
        PlayerName = GUI.TextField(Rect, PlayerName);

        if (GUI.GetNameOfFocusedControl() == string.Empty) {
            GUI.FocusControl(CONTROL_NAME);
        }
    }

    private Rect Rect {
        get {
            var anchor = TransformToGuiFinder.Find(transform);
            return new Rect(anchor.x - WIDTH / 2, anchor.y - HEIGHT / 2, WIDTH, HEIGHT);
        }
    }
}
