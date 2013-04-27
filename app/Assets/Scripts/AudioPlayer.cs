using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour {
    public AudioSource PlayGameSound;
    public AudioSource[] SelectSounds;
    public AudioSource[] BounceSounds;

    private static AudioPlayer instance;
    public static AudioPlayer Instance {
        get {
            if (instance == null) {
                instance = GameObject.Find("/Global/AudioPlayer").GetComponent<AudioPlayer>();
            }

            return instance;
        }
    }

    public void PlayGame() {
        PlayGameSound.Play();
    }

    public void Select() {
        PlayRandom(SelectSounds);
    }

    public void Bounce() {
        PlayRandom(BounceSounds);
    }

    private void PlayRandom(AudioSource[] AudioSources) {
        var audioSource = AudioSources[Random.Range(0, AudioSources.Length)];
        audioSource.Play();
    }
}
