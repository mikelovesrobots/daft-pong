using UnityEngine;
using System.Collections;

public class PaddleAiPersonality : MonoBehaviour {
    private const float MIN_WAIT_BETWEEN_PERSONALITY_CHANGES = 2f;
    private const float MAX_WAIT_BETWEEN_PERSONALITY_CHANGES = 10f;
    public PaddleAi[] AiBehaviours;
    private PaddleAi currentAi;

    void Start() {
        ChangePersonality();
        StartCoroutine(WaitThenSwitchPersonality());
    }

    void FixedUpdate() {
        if (BallFinder.Instance.Find() != null) {
            currentAi.Tick();
        }
    }

    private IEnumerator WaitThenSwitchPersonality() {
        yield return new WaitForSeconds(WaitBetweenChangePersonalitys);
        ChangePersonality();
        StartCoroutine(WaitThenSwitchPersonality());
    }

    private void ChangePersonality() {
        currentAi = RandomAi;
    }

    private float WaitBetweenChangePersonalitys {
        get { return Random.Range(MIN_WAIT_BETWEEN_PERSONALITY_CHANGES, MAX_WAIT_BETWEEN_PERSONALITY_CHANGES); }
    }

    private PaddleAi RandomAi {
        get {
            return AiBehaviours[UnityEngine.Random.Range(0, AiBehaviours.Length)];
        }
    }
}
