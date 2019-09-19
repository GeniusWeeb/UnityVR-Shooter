using System;
using UnityEngine.Audio;
using UnityEngine;

public class AuManager : MonoBehaviour
{

    public sound[] sounds;
    void Awake()
    {
        foreach (sound n in sounds)
        {
            n.source =  gameObject.GetComponent<AudioSource>();

            n.source.clip = n.Audio;
            n.source.volume = n.volume;
            n.source.pitch = n.pitch;
            n.source.name = n.Name;

        }



    }


    public void Play(string name)
    {

       sound s =  Array.Find(sounds, sound => sound.Name == name);
        {
                s.source.Play();

        }
    }
}
