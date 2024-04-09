using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    private Animator animator;
    private bool isOpen = false;

    public bool small = false;
    public bool big = false;

    public AudioManager audioManager; // Reference to AudioManager for playing sound effects


    private void Awake() {
        animator = GetComponent<Animator>();
    }

    
    public void ToggleDoor()
    {
        isOpen = !isOpen;
        

        // If AudioManager reference is set and door is closing
        if (audioManager != null && small)
        {
            animator.SetBool("isOpen", isOpen);
            audioManager.PlayDoorCloseSoundSmall(); // Call method in AudioManager to play door closing sound
        }

        if(audioManager != null && big)
        {
            animator.SetBool("isOpen", isOpen);
            audioManager.PlayDoorCloseSoundBig();
        }
    }
}
