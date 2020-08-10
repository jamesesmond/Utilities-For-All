using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("My Assets/Simple Audio Event"))]
public class SimpleAudioEvent : AudioEvent
{
    //https://www.youtube.com/watch?v=6vmRwLYWNRo&t=3s

    public AudioClip[] clips;

    [Header("Volume Range")]
    [Range(0, 1)]
    public float minVolume;
    [Range(0, 1)]
    public float maxVolume;

    [Header("Pitch Range")]
    [Range(-3, 3)]
    public float minPitch;
    [Range(-3, 3)]
    public float maxPitch;

    public FloatVariable SFXMasterVolume;

    public override void Play(AudioSource source)
    {
        if (clips.Length == 0) return;

        source.pitch = Random.Range(minPitch, maxPitch);
        source.PlayOneShot(clips[Random.Range(0, clips.Length)], Random.Range(minVolume, maxVolume) * SFXMasterVolume.Value);
    }
}
