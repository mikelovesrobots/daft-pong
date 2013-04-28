using UnityEngine;
using System.Collections;

public class PaddleHitRecorder : MonoBehaviour {
    private string playerName;

    public void Initialize(string playerName) {
        this.playerName = playerName;
    }

    void OnCollisionEnter() {
        GameHistory.Instance.RecordShooter(playerName);
    }
}
