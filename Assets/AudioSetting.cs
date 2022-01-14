using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSetting : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    //public AudioListener al;

    private void Start()
    {
        //if (!PlayerPrefs.HasKey("musicVolume"))
        //{
        //    PlayerPrefs.SetFloat("musicVolume", 1);
        //    Load();
        //}

        //else
        //{
        //    Load();
        //}
        volumeSlider.value = AudioListener.volume;  
    }

    //public void ChangeVolume()
    //{
    //    AudioListener.volume = volumeSlider.value;
    //    Save();
    //}

    //private void Load()
    //{
    //    volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    //}

    //private void Save()
    //{
    //    PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    //}
    private void Update()
    {
        AudioListener.volume = volumeSlider.value;
        SaveSettings.Setting.volumeSetting = volumeSlider.value;
    }
}
