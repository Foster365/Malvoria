using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundUIController : MonoBehaviour
{
    [SerializeField] Slider musicSlider, sfxSlider;

    public void ToggleMusic()
    {
        if(AudioManager.instance) AudioManager.instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        if (AudioManager.instance) AudioManager.instance.ToggleSFX();
    }

    public void MusicVolume()
    {
        if (AudioManager.instance) AudioManager.instance.MusicVolume(musicSlider.value);
    }

    public void SFXVolume()
    {
        if (AudioManager.instance) AudioManager.instance.SFXVolume(sfxSlider.value);
    }

}
