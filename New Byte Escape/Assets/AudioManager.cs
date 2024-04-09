using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip doorSmall;
    public AudioClip doorBig;
    public AudioClip footsteps;

    private void Start() {
        musicSource.clip = background;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayDoorCloseSoundSmall(){
        SFXSource.PlayOneShot(doorSmall);  
    }

    public void PlayDoorCloseSoundBig(){
        SFXSource.PlayOneShot(doorBig);
    }
}