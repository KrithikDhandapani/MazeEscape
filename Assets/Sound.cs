using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]

public class Sound 
{
    public AudioClip clip;
    public float volume;
    public float pitch;
    public string name;

    [HideInInspector]
    public AudioSource source;
    
    
}
