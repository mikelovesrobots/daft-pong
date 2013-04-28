using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerRegistry : MonoBehaviour {
    public List<GameObject> Players = new List<GameObject>();

    private static PlayerRegistry instance;
    public static PlayerRegistry Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/PlayerRegistry").GetComponent<PlayerRegistry>();
            }

            return instance;
        }
    }

    public void Register(GameObject player) {
        Players.Add(player);
    }
}
