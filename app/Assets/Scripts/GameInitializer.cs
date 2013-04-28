using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInitializer : MonoBehaviour {
    public Transform LeftChannel;
    public Transform RightChannel;

    void Start () {
        AudioPlayer.Instance.PlayGame();
        SpawnPlayers();
    }

    private void SpawnPlayers() {
        for (int i=0; i < 50; i++) {
            PaddleFactory.Ai(LeftChannel.position);
            PaddleFactory.Ai(RightChannel.position);
        }
        PaddleFactory.Player(Vector3.zero);
    }
}
