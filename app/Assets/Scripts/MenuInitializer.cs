using UnityEngine;
using System.Collections;

public class MenuInitializer : MonoBehaviour {
    public TitleAnimation TitleAnimation;

    void Start () {
        TitleAnimation.Animate();
    }
}
