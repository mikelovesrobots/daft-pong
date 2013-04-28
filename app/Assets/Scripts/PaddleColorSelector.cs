using UnityEngine;
using System.Collections;

public class PaddleColorSelector : MonoBehaviour {
    public Color Color;
    public GameObject Highlight;
    public ColorChanger ColorChanger;

    void OnMouseDown() {
        PlayerOptions.Color = Color;
        AudioPlayer.Instance.Select();
    }

    void Start() {
        ColorChanger.ChangeColor(Color);
    }

    void Update() {
        Highlight.SetActive(ShouldShowColor);
    }

    private bool ShouldShowColor {
        get { return PlayerOptions.Color == Color; }
    }
}
