using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AdminModeTriggerer : MonoBehaviour {
    private const float WAIT_TIME = 120f;
    public ActionBase AdminModeAction;

    public void Initialize() {
        StartCoroutine(WaitThenEnterAdminMode());
    }

    public IEnumerator WaitThenEnterAdminMode() {
        yield return new WaitForSeconds(WAIT_TIME);
        AdminModeAction.Act();
    }
}
