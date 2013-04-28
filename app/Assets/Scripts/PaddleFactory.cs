using UnityEngine;
using System.Collections;

public class PaddleFactory : MonoBehaviour {
    public static GameObject Ai(Vector3 position) {
        var instance = Spawn(position);
        var ai = instance.AddComponent<PaddleAiPerfectController>();
        ai.Ball = GameObject.Find("Ball").transform;
        return instance;
    }

    public static GameObject Player(Vector3 position) {
        var instance = Spawn(position);
        instance.GetComponent<ColorChanger>().ChangeColor(PlayerOptions.Color);
        instance.AddComponent<PaddlePlayerController>();
        return instance;
    }

    private static GameObject Spawn(Vector3 position) {
        return GameObject.Instantiate(Prefab, position, Quaternion.identity) as GameObject;
    }

    private static GameObject Prefab {
        get { return PrefabRepository.Instance.Paddle; }
    }

}
