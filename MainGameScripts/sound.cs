using UnityEngine.Audio;
using UnityEngine;



[System.Serializable]
public class sound
{     public string Name;
    public AudioClip Audio;
   
    
    [Range(0f,3f)]
    public float volume;
    
    [Range(0.1f,3f)]
    public float pitch;


    [HideInInspector]
    public AudioSource source;

}
