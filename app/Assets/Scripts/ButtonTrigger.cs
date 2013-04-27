using UnityEngine;
using System.Collections;

public class ButtonTrigger : TriggerBase {
    public MaterialChanger MaterialChanger;
    public Material HighlightMaterial;
    public Material StandardMaterial;

    void OnMouseDown () {
        MaterialChanger.ChangeMaterial(HighlightMaterial);
        AudioPlayer.Instance.Select();
    }

    void OnMouseUp () {
        MaterialChanger.ChangeMaterial(StandardMaterial);
        Trigger();
    }
}
