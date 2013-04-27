using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TitleAnimation : MonoBehaviour {
    private const float FADE_ANIMATION_TIME = 2f;
    private const float MOVE_ANIMATION_TIME = 1f;
    private const float FADE_IN_AMOUNT = 0.5f;
    private const float FADE_OUT_AMOUNT = 0f;
    private const string NAMED_COLOR_VALUE = "_TintColor";
    public GameObject Mikelovesrobots;
    public GameObject Title;
    public GameObject StartGame;

    public void Animate() {
        FadeIn(Mikelovesrobots, 0f);
        FadeOut(Mikelovesrobots, 2.5f);
        FadeIn(Title, 4f);
        MoveUp(Title, Vector3.up * 2, 5f);
        FadeIn(StartGame, 6f);
    }

    private void FadeIn(GameObject target, float delay) {
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

    private void SetColorToTransparent(GameObject target) {
        var color = target.renderer.material.GetColor(NAMED_COLOR_VALUE);
        color.a = 0f;
        target.renderer.material.SetColor(NAMED_COLOR_VALUE, color);
    }

    private void FadeOut(GameObject target, float delay) {
        var options = new Hashtable();
        options.Add("delay", delay);
        options.Add("amount", FADE_OUT_AMOUNT);
        options.Add("time", FADE_ANIMATION_TIME);
        options.Add("namedcolorvalue", NAMED_COLOR_VALUE);
        options.Add("easetype", "easeInOutQuad");
        options.Add("oncomplete", "OnFadeOutComplete");
        options.Add("oncompletetarget", gameObject);
        options.Add("oncompleteparams", target);
        iTween.FadeTo(target, options);
    }

    private void OnFadeOutComplete(GameObject target) {
        target.SetActive(false);
    }

    private void MoveUp(GameObject target, Vector3 position, float delay) {
        var options = new Hashtable();
        options.Add("delay", delay);
        options.Add("position", position);
        options.Add("time", MOVE_ANIMATION_TIME);
        options.Add("easetype", "easeInOutQuad");
        iTween.MoveTo(target, options);
    }
}
