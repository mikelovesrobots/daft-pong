using UnityEngine;
using System.Collections;

public class ScoreIncrementAction : ActionBase {
    public int Score = 0;
    public ScoreRenderer ScoreRenderer;
    
    public override void Act() {
        Score++;
        ScoreRenderer.Render(Score);
    }
}
