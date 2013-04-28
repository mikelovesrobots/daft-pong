using UnityEngine;
using System.Collections;

public class AdminModeAction : ActionBase {
    public GameObject AdminMode;
    public AdminModeMessageWindow AdminModeMessageWindow;

    public override void Act() {
        AdminMode.SetActive(true);
        AdminModeMessageWindow.Initialize();
        foreach (var player in PlayerRegistry.Instance.Players) {
            player.GetComponent<PaddlePlayerController>().AllowFreeMovement();
        }
    }
}
