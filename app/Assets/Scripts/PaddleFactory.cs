using UnityEngine;
using System.Collections;

public class PaddleFactory : MonoBehaviour {
    public static GameObject Ai(Vector3 position) {
        var instance = Spawn(position);
        instance.GetComponent<PaddleInitializer>().Initialize(PaddleNames.Random, RandomColor, new Color(1,1,1,1), false);
        return instance;
    }

    public static GameObject Player(Vector3 position) {
        var instance = Spawn(position);
        instance.GetComponent<PaddleInitializer>().Initialize(PlayerOptions.Name, 
                PlayerOptions.Color.FullTransparent(), 
                PlayerOptions.Color.FullBright(), 
                true);

        Destroy(instance.GetComponent<PaddleAiPersonality>());
        instance.AddComponent<PaddlePlayerController>();
        instance.name = "Player";
        EmbiggenPlayer(instance.transform);
        PlayerRegistry.Instance.Register(instance);
        return instance;
    }

    private static void EmbiggenPlayer(Transform instance) {
        var scale = instance.localScale;
        scale.x = 1.4f;
        instance.localScale = scale;
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
