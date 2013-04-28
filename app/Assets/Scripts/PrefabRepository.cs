using UnityEngine;
using System.Collections;

public class PrefabRepository : MonoBehaviour {
    public GameObject Paddle;
    public GameObject Ball;

    private static PrefabRepository instance;
    public static PrefabRepository Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/PrefabRepository").GetComponent<PrefabRepository>();
            }

            return instance;
        }
    }
}
