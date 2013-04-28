using UnityEngine;
using System.Collections;

public class GoalNameRenderer : MonoBehaviour {
    private const float WIDTH = 650;
    private const float HEIGHT = 80;
    private const float HANG_TIME = 3f;
    public GUISkin GuiSkin;
    private string playerName;

    void OnGUI () {
        GUI.skin = GuiSkin;
        GUI.Label(Rect, playerName);
    }

    public void Render(string playerName) {
        this.playerName = playerName;
        gameObject.SetActive(true);
        StartCoroutine(WaitThenDisable());
    }

    private IEnumerator WaitThenDisable() {
        yield return new WaitForSeconds(HANG_TIME);
        gameObject.SetActive(false);
    }

    private Rect Rect {
        get {
            var anchor = TransformToGuiFinder.Find(transform);
            return new Rect(anchor.x - WIDTH / 2, anchor.y - HEIGHT / 2, WIDTH, HEIGHT);
        }
    }
}
