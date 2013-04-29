using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class NetworkConnectTipSequencer : MonoBehaviour {
    public TipRenderer TipRenderer;
    private int gamesBeingPlayed;

    public void Sequence() {
        Rules();
        gamesBeingPlayed = UnityEngine.Random.Range(10, 19);
    }

    private void Rules() {
        TipRenderer.Render("First team to 20 points wins!", () => GamesBeingPlayed());
    }

    private void GamesBeingPlayed() {
        TipRenderer.Render("There are " + gamesBeingPlayed + " games being played simultaneously.", () => PlayersLive());
    }

    private void PlayersLive() {
        var players = gamesBeingPlayed * 50;
        TipRenderer.Render("That's about " + players + " players!", () => PlayerPlayed());
    }

    private void PlayerPlayed() {
        var gamesPlayed = GamesPlayed;
        var games = "games";
        if (gamesPlayed == 1) {
            games = "game";
        }

        TipRenderer.Render("You've played " + gamesPlayed + " " + games + " so far!", () => LudumDare());
    }
    
    private int GamesPlayed {
        get { return PlayerPrefs.GetInt("GamesPlayed"); }
    }

    private void LudumDare() {
        TipRenderer.Render("Thanks for playing. You're awesome!", () => AlmostThere());
    }

    private void AlmostThere() {
        TipRenderer.Render("You're almost there. Just sit tight.", () => Rules());
    }
}

