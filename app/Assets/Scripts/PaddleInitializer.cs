using UnityEngine;
using System.Collections;

public class PaddleInitializer : MonoBehaviour {
    public PaddleNameRenderer PaddleNameRenderer;
    public PaddleHitRecorder PaddleHitRecorder;
    public ColorChanger ColorChanger;

    public void Initialize(string name, Color color, Color textColor, bool boldName) {
        PaddleNameRenderer.Initialize(name, textColor, boldName);
        PaddleHitRecorder.Initialize(name);
        ColorChanger.ChangeColor(color);
    }
}
