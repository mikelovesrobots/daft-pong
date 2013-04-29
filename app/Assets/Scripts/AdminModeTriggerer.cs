using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AdminModeTriggerer : MonoBehaviour {
    private const float WAIT_TIME = 180f;
    public ActionBase AdminModeAction;

    public void Initialize() {
        if (CanTriggerAdminMode) {
            StartCoroutine(WaitThenEnterAdminMode());
        }
    }

    private bool CanTriggerAdminMode {
        get { return (GamesPlayed % 2) == 1; }
    }

    private int GamesPlayed {
        get { return PlayerPrefs.GetInt("GamesPlayed"); }
    }

    private IEnumerator WaitThenEnterAdminMode() {
        yield return new WaitForSeconds(WAIT_TIME);
        AdminModeAction.Act();
    }
}
