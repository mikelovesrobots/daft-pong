using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class NetworkConnectMessageSequenceAnimator : MonoBehaviour {
    private const float FADE_ANIMATION_TIME = 2f;
    private const float MOVE_ANIMATION_TIME = 1f;
    private const float FADE_IN_AMOUNT = 0.5f;
    private const float FADE_OUT_AMOUNT = 0f;
    private const string NAMED_COLOR_VALUE = "_TintColor";
    public GameObject ConnectingToMatchmakingServers;
    public GameObject RetrievingGamesInProgress;
    public GameObject JoiningGameInProgress;
    public GameObject ConnectionTimeout;
    public ActionBase ExitAction;

    public void Animate() {
        Connect();
    }

    private void Connect() {
        FadeIn(ConnectingToMatchmakingServers, 0f);
        FadeOut(ConnectingToMatchmakingServers, 2.5f, () => PostConnect());
    }

    private void PostConnect() {
        if (FiftyPercentChance) {
            Connect();
        } else {
            RetrieveGames();
        }
    }

    private void RetrieveGames() {
        FadeIn(RetrievingGamesInProgress, 0f);
        FadeOut(RetrievingGamesInProgress, 2.5f, () => PostRetrievingGamesInProgress());
    }

    private void PostRetrievingGamesInProgress() {
        if (FiftyPercentChance) {
            RetrieveGames();
        } else {
            Join();
        }
    }

    private void Join() {
        FadeIn(JoiningGameInProgress, 0f);
        FadeOut(JoiningGameInProgress, 2.5f, () => PostJoin());
    }

    private void PostJoin() {
        if (ThirtyPercentChance) {
            ExitAction.Act();
        } else if (FiftyPercentChance) {
            Join();
        } else {
            ConnectionFailed();
        }
    }

    private void ConnectionFailed() {
        FadeIn(ConnectionTimeout, 0f);
        FadeOut(ConnectionTimeout, 2.5f, () => Join());
    }

    private bool FiftyPercentChance {
        get { return UnityEngine.Random.Range(0, 2) == 0; }
    }

    private bool ThirtyPercentChance {
        get { return UnityEngine.Random.Range(0, 3) == 0; }
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

    private void FadeOut(GameObject target, float delay, Action callback) {
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

    private void OnFadeOutComplete(NetworkConnectFadeOptions options) {
        options.Target.SetActive(false);
        options.Callback();
    }
}

