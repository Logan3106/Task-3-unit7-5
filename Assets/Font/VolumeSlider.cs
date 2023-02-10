using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] Slider volumeSlider = null;
    [SerializeField] Slider SFXSlider = null;

    [SerializeField] AudioClip MainaudioClip = null;
    [SerializeField] AudioClip SFXudioClip = null;


    private void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else
        {
            Load();
        }

        if (!PlayerPrefs.HasKey("SFXVolume"))
        {
            PlayerPrefs.SetFloat("SFXVolume", 1);
            LoadSFX();
        }

        else
        {
            LoadSFX();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }


    public void ChangeVolumeSFX()
    {
        AudioListener.volume = SFXSlider.value;
        SaveSFX();
    }

    private void LoadSFX()
    {
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
    }

    private void SaveSFX()
    {
        PlayerPrefs.SetFloat("SFXVolume", SFXSlider.value);
    }


}
