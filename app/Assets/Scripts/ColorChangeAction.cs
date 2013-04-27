using UnityEngine;
using System.Collections;

public class ColorChangeAction : ActionBase {
    public ColorChanger ColorChanger;
    public Color Color;

    public override void Act() {
        ColorChanger.ChangeColor(Color);
    }
}
