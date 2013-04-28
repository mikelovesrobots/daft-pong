using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameHistory : MonoBehaviour {
    private List<string> shooters = new List<string>();

    private static GameHistory instance;
    public static GameHistory Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/GameHistory").GetComponent<GameHistory>();
            }

            return instance;
        }
    }

    public void RecordShooter(string name) {
        shooters.Add(name);
    }

    public string LastShooter {
        get { return shooters[shooters.Count - 1]; }
    }

}
