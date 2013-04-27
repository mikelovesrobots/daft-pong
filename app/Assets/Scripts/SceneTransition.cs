using UnityEngine;
using System.Collections;

public class SceneTransition : MonoBehaviour {
    private const float FADE_IN_TIME = 0.33f;
    private const float FADE_OUT_AMOUNT = 1f;
    private const float FADE_OUT_TIME = 0.33f;

    private string levelName;

    private static SceneTransition instance;
    public static SceneTransition Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/SceneTransition").GetComponent<SceneTransition>();
            }

            return instance;
        }
    }

    public void Start() {
        FadeIn();
    }

    public void TransitionTo(string levelName) {
        this.levelName = levelName;

        FadeOut();
    }

    private void FadeIn() {
        iTween.CameraFadeAdd();

        var options = new Hashtable();
        options.Add("amount", FADE_OUT_AMOUNT);
        options.Add("time", FADE_IN_TIME);

        iTween.CameraFadeFrom(options);
    }

    private void FadeOut() {
        iTween.CameraFadeAdd();

        var options = new Hashtable();
        options.Add("amount", FADE_OUT_AMOUNT);
        options.Add("time", FADE_OUT_TIME);
        options.Add("oncomplete", "LoadLevel");
        options.Add("oncompletetarget", gameObject);

        iTween.CameraFadeTo(options);
    }

    private void LoadLevel() {
        Application.LoadLevel(levelName);
    }
}

