using UnityEngine;
using System.Collections;

public class AdminModeMessageWindow : MonoBehaviour {
    private const float WINDOW_WIDTH = 650;
    private const float WINDOW_HEIGHT = 120;
    private const float MESSAGE_HEIGHT = 40;
    private const float BUTTON_HEIGHT = 40;
    private const float BUTTON_WIDTH = 40;
    private string Message;

    public void Initialize() {
        Message = "Could not sync player records to database server. Reason \"Player " + PlayerOptions.Name  + " log corrupted\". Entering admin-mode";
    }

    void OnGUI () {
        GUI.Window(0, WindowRect, MessageWindow, "Error");
    }

    void MessageWindow(int windowID) {
        GUI.Label(LabelRect, Message);
        if (GUI.Button(ButtonRect, "OK")) {
            enabled = false;
        }
    }

    private Rect WindowRect {
        get {
            var anchor = TransformToGuiFinder.Find(transform);
            return new Rect(anchor.x - WINDOW_WIDTH / 2, anchor.y - WINDOW_HEIGHT / 2, WINDOW_WIDTH, WINDOW_HEIGHT);
        }
    }

    private Rect LabelRect {
        get { return new Rect(10, 20, WINDOW_WIDTH, MESSAGE_HEIGHT); }
    }
    private Rect ButtonRect {
        get { return new Rect((WINDOW_WIDTH / 2) - (BUTTON_WIDTH / 2), 20 + MESSAGE_HEIGHT, BUTTON_WIDTH, BUTTON_HEIGHT); }
    }

}
