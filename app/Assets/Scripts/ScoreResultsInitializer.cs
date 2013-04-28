using UnityEngine;
using System.Collections;

public class ScoreResultsInitializer : MonoBehaviour {
    public ScoreResultsTitleRenderer ScoreResultsTitleRenderer;

    void Start() {
        ScoreResultsTitleRenderer.Initialize(ScoreResultsOptions.PlayerWon);
    }
}
