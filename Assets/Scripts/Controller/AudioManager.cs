using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    [SerializeField] Sound[] musicSounds, sfxSounds;

    [SerializeField] AudioSource musicSource, sfxSource;

    public Sound[] MusicSounds { get => musicSounds; set => musicSounds = value; }
    public Sound[] SfxSounds { get => sfxSounds; set => sfxSounds = value; }
    public AudioSource MusicSource { get => musicSource; set => musicSource = value; }
    public AudioSource SfxSource { get => sfxSource; set => sfxSource = value; }

    private void Awake()
    {
        if(instance == null)
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
        PlayMusic("Game_Background_Music");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.Name == name);

        if (s == null) Debug.Log("Sound not found!");
        else
        {
            musicSource.clip = s.AudioClip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.Name == name);

        if (s == null) Debug.Log("SFX not found!");
        else
        {
            sfxSource.PlayOneShot(s.AudioClip);
        }
    }

    public bool GetMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.Name == name);

        if (s == null) return false;
        else return true;
    }

    public bool GetSFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.Name == name);

        if (s == null) return false;
        else return true;
    }
    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
}
