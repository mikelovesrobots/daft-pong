using UnityEngine;
using System.Collections;

public class QuitGameAction : ActionBase {
    public override void Act() {
        Application.Quit();
    }
}
