using UnityEngine;
using System.Collections;

public class PaddleColorSelector : MonoBehaviour {
    public Color Color;
    public GameObject Highlight;
    public ColorChanger ColorChanger;

    void OnMouseDown() {
        Player.Color = Color;
    }

    void Start() {
        ColorChanger.ChangeColor(Color);
    }

    void Update() {
        Highlight.SetActive(ShouldShowColor);
    }

    private bool ShouldShowColor {
        get { return Player.Color == Color; }
    }
}
