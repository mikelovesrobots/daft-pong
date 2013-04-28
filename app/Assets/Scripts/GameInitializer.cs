using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInitializer : MonoBehaviour {
    private Vector3 LEFT = new Vector3(-5, 0, 0);
    private Vector3 RIGHT = new Vector3(5, 0, 0);

    void Start () {
        AudioPlayer.Instance.PlayGame();
        SpawnPlayers();
    }

    private void SpawnPlayers() {
        for (int i=0; i < 1; i++) {
            PaddleFactory.Ai(LEFT);
            PaddleFactory.Ai(RIGHT);
        }
        PaddleFactory.Player(Vector3.zero);
    }
}
