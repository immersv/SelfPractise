﻿
using UnityEngine;
using System;


[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip audioClip;
    [Range(0f,1f)]
    public float volume;
    [HideInInspector]
    public AudioSource audioSource;
}


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    private void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.audioSource = gameObject.AddComponent<AudioSource>();
            s.audioSource.clip = s.audioClip;
            s.audioSource.volume = s.volume;
        }
        
    }
  
    public void PlayAudio()
    {
        Sound s = Array.Find(sounds, sound => sound.audioClip);
        if (s == null)
        {
            Debug.Log("Audio clip not found");
            return;
        }
        s.audioSource.Play();
    }
}
