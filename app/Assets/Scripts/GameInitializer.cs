using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInitializer : MonoBehaviour {
    void Start () {
        AudioPlayer.Instance.PlayGame();
    }
}
