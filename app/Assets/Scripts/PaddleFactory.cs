using UnityEngine;
using System.Collections;

public class PaddleFactory : MonoBehaviour {
    public static GameObject Ai(Vector3 position) {
        var instance = Spawn(position);
        instance.GetComponent<PaddleInitializer>().Initialize(PaddleNames.Random, RandomColor);
        return instance;
    }

    public static GameObject Player(Vector3 position) {
        var instance = Spawn(position);
        instance.GetComponent<PaddleInitializer>().Initialize(PlayerOptions.Name, PlayerOptions.Color);
        Destroy(instance.GetComponent<PaddleAiPersonality>());
        instance.AddComponent<PaddlePlayerController>();
        return instance;
    }

    private static GameObject Spawn(Vector3 position) {
        return GameObject.Instantiate(Prefab, position, Quaternion.identity) as GameObject;
    }

    private static GameObject Prefab {
        get { return PrefabRepository.Instance.Paddle; }
    }

    private static Color RandomColor {
        get { return PaddleColors.Instance.Random; }
    }
}
