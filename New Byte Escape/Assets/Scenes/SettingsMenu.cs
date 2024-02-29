using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MainVolumeSound", volume);
    }

    public void SetFullscreen(bool isToggled)
    {
        Screen.fullScreen = isToggled;
    }
}
