using UnityEngine;
using System.Collections;

public class PaddleColors : MonoBehaviour {
    public Color[] Colors;

    private static PaddleColors instance;
    public static PaddleColors Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/PaddleColors").GetComponent<PaddleColors>();
            }

            return instance;
        }
    }

    public Color Random {
        get { return Colors[UnityEngine.Random.Range(0, Colors.Length)]; }
    }
}
