using UnityEngine;
using System;
using System.Collections;

public class FadeAnimator : MonoBehaviour {
    private const float FADE_ANIMATION_TIME = 1f;
    private const float MOVE_ANIMATION_TIME = 1f;
    private const float FADE_OUT_DELAY = 1.5f;
    private const float FADE_IN_AMOUNT = 0.5f;
    private const float FADE_OUT_AMOUNT = 0f;
    private const string NAMED_COLOR_VALUE = "_TintColor";

    private static FadeAnimator instance;
    public static FadeAnimator Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/FadeAnimator").GetComponent<FadeAnimator>();
            }

            return instance;
        }
    }

    public void FadeIn(GameObject target, float delay) {
        target.SetActive(true);

        SetColorToTransparent(target);

        var options = new Hashtable();
        options.Add("delay", delay);
        options.Add("amount", FADE_IN_AMOUNT);
        options.Add("time", FADE_ANIMATION_TIME);
        options.Add("namedcolorvalue", NAMED_COLOR_VALUE);
        options.Add("easetype", "easeInOutQuad");
        iTween.FadeTo(target, options);
    }

    public void FadeOut(GameObject target, float delay, Action callback) {
        var parameters = new NetworkConnectFadeOptions(target, callback);

        var options = new Hashtable();
        options.Add("delay", delay);
        options.Add("amount", FADE_OUT_AMOUNT);
        options.Add("time", FADE_ANIMATION_TIME);
        options.Add("namedcolorvalue", NAMED_COLOR_VALUE);
        options.Add("easetype", "easeInOutQuad");
        options.Add("oncomplete", "OnFadeOutComplete");
        options.Add("oncompletetarget", gameObject);
        options.Add("oncompleteparams", parameters);
        iTween.FadeTo(target, options);
    }

    private void SetColorToTransparent(GameObject target) {
        var color = target.renderer.material.GetColor(NAMED_COLOR_VALUE);
        color.a = 0f;
        target.renderer.material.SetColor(NAMED_COLOR_VALUE, color);
    }

    private void OnFadeOutComplete(NetworkConnectFadeOptions options) {
        options.Target.SetActive(false);
        options.Callback();
    }
}
