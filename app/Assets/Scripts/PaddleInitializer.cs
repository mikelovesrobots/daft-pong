using UnityEngine;
using System.Collections;

public class PaddleInitializer : MonoBehaviour {
    public PaddleNameRenderer PaddleNameRenderer;
    public ColorChanger ColorChanger;

    public void Initialize(string name, Color color, Color textColor) {
        PaddleNameRenderer.Initialize(name, textColor);
        ColorChanger.ChangeColor(color);
    }
}
