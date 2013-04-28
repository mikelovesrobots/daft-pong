using UnityEngine;
using System.Collections;

public class BallFactory : MonoBehaviour {
    public static void Create() {
        var instance = GameObject.Instantiate(Prefab, Random.insideUnitCircle, Quaternion.identity) as GameObject;
        instance.GetComponent<BallInitializer>().Initialize();

        BallFinder.Instance.RegisterBall(instance);
    }

    private static GameObject Prefab {
        get { return PrefabRepository.Instance.Ball; }
    }
}

