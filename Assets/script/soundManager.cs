using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class soundManager : MonoBehaviour
{
    private static soundManager instance;
    public static soundManager Instance { get { return instance; } }

    public AudioSource soundEffect;
    public AudioSource soundMusic;

    public soundType[] sounds;

    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        playMusic(global::sounds.music);
    }

    private void playMusic(sounds sound)
    {
        AudioClip clip = getSoundClip(sound);
        if(clip!=null)
        {
            soundMusic.clip = clip;
            soundMusic.Play();
        }
        else
        {
            Debug.Log("error");
        }
    }
    public void play(sounds sound)
    {
        AudioClip clip = getSoundClip(sound);
        if(clip!=null)
        {
            soundEffect.PlayOneShot(clip);
        }
        else
        {
            Debug.Log("error");
        }
    }

    private AudioClip getSoundClip(sounds sound)
    {
        soundType item = Array.Find(sounds, i => i.SoundType == sound);
        if (item != null)
            return item.soundClip;
        return null;
    }

    
}
[Serializable]
public class soundType
{
    public sounds SoundType;
    public AudioClip soundClip;

}
public enum sounds
{
    buttonClick,
    music,
    playerMove,
    playerDeath,
    pickKey,
    teleporter,
    rain,
}
