using UnityEngine;
using System.Collections;

public class LayerChanger : MonoBehaviour {
    public void ChangeLayer(int layer) {
        SetLayerRecursively(gameObject, layer);
    }

    private void SetLayerRecursively(GameObject gameObject, int layer) {
        gameObject.layer = layer;

        foreach (Transform child in gameObject.transform ) {
            SetLayerRecursively(child.gameObject, layer);
        }
    }
}
