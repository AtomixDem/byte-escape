using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool isOpen = false;

    public bool small = false;
    public bool big = false;

    public AudioManager audioManager; // Reference to AudioManager for playing sound effects

    public void ToggleDoor()
    {
        isOpen = !isOpen;
        gameObject.SetActive(!isOpen);

        // If AudioManager reference is set and door is closing
        if (audioManager != null && small)
        {
            audioManager.PlayDoorCloseSoundSmall(); // Call method in AudioManager to play door closing sound
        }

        if(audioManager != null && big)
        {
            audioManager.PlayDoorCloseSoundBig();
        }
    }
}
