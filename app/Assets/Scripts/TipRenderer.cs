using UnityEngine;
using System;
using System.Collections;

public class TipRenderer : MonoBehaviour {
    private const float WIDTH = 650;
    private const float HEIGHT = 80;
    private const float HANG_TIME = 3f;
    public GUISkin GuiSkin;
    private string tip;
    private Action callback;

    void OnGUI () {
        GUI.skin = GuiSkin;
        GUI.Label(Rect, tip);
    }

    public void Render(string tip, Action callback) {
        this.tip = tip;
        this.callback = callback;
        StartCoroutine(WaitThenCallback());
    }

    private IEnumerator WaitThenCallback() {
        yield return new WaitForSeconds(HANG_TIME);
        callback();
    }

    private Rect Rect {
        get {
            var anchor = TransformToGuiFinder.Find(transform);
            return new Rect(anchor.x - WIDTH / 2, anchor.y - HEIGHT / 2, WIDTH, HEIGHT);
        }
    }
}
