using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioController : MonoBehaviour
{
    public Audio[] audios;
    private void Awake()
    {
        foreach(Audio a in audios)
        {          
            a.audioSource = gameObject.AddComponent<AudioSource>();
            a.audioSource.clip = a.audioClip;
            a.audioSource.volume = a.volume;
        }
    }
    public void PlayAudio(string name)
    {
        Audio a = Array.Find(audios,audio=>audio.audioName==name);
        if (a == null)
        {
            Debug.Log("Audio clip not found");
            return;
        }
        a.audioSource.Play();
    }
}
[System.Serializable]
public class Audio
{
    [HideInInspector]
    public AudioSource audioSource;
    public string audioName;
    public AudioClip audioClip;
    [Range(0,1)]
    public float volume;

}
