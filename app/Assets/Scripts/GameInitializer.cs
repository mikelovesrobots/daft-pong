using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInitializer : MonoBehaviour {
    public Transform LeftChannel;
    public Transform RightChannel;
    public AdminModeTriggerer AdminModeTriggerer;
    public int PlayersPerSide = 50;

    void Start () {
        AudioPlayer.Instance.PlayGame();
        SpawnPlayers();
        BallFactory.Create();
        AdminModeTriggerer.Initialize();
    }

    private void SpawnPlayers() {
        for (int i=0; i < PlayersPerSide; i++) {
            PaddleFactory.Ai(LeftChannel.position);
            PaddleFactory.Ai(RightChannel.position);
        }
        PaddleFactory.Player(RightChannel.position); 
    }
}
