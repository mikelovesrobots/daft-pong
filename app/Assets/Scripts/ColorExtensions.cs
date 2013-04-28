using UnityEngine;
using System.Collections;

public static class ColorExtensions { 
    public static Color FullBright(this Color color) {
        var newColor = color;
        newColor.a = 1.0f;
        return newColor;
    }
}
