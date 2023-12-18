using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicControl : MonoBehaviour
{
    public AudioSource Soundtrack;

    public Slider slider;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume");
        Debug.Log(slider.value);
    }

    public void OnSlider(float value)
    {
        Soundtrack.volume = value;
        Debug.Log(PlayerPrefs.GetFloat("MusicVolume"));
    }

    public void OnMute()
    {
        Soundtrack.volume = 0;
        slider.value = 0;
    }

    public void MaxVolume()
    {
        Soundtrack.volume = 1;
        slider.value = 1;
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("MusicVolume", Soundtrack.volume);
    }

    public void ApplyChanges()
    {
        PlayerPrefs.Save();
    }
}
