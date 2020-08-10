using UnityEngine;

public abstract class AudioEvent : ScriptableObject
{
    //https://www.youtube.com/watch?v=6vmRwLYWNRo&t=3s
    public abstract void Play(AudioSource source);
}
