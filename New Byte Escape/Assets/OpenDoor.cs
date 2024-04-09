using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenDoor : MonoBehaviour
{
    public GameObject containerObject;
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    private bool isOnCooldown = false; // Flag to track if on cooldown
    private float cooldownDuration = 2f; // Cooldown duration in seconds
    private float cooldownTimer = 0f; // Timer to track cooldown progress

    private void ShowInteract()
    {
        containerObject.SetActive(true);
    }

    private void HideInteract()
    {
        containerObject.SetActive(false);
    }

    void Update()
    {
        if (isInRange)
        {
            ShowInteract();

            // Check if interact key is pressed and not on cooldown
            if (Input.GetKeyDown(interactKey) && !isOnCooldown)
            {
                interactAction.Invoke();

                // Start cooldown
                StartCooldown();
            }
        }
        else
        {
            HideInteract();
        }

        // Update cooldown timer if on cooldown
        if (isOnCooldown)
        {
            cooldownTimer += Time.deltaTime;

            // Check if cooldown is over
            if (cooldownTimer >= cooldownDuration)
            {
                isOnCooldown = false;
                cooldownTimer = 0f; // Reset cooldown timer
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("IS IN RANGE");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("IS NOT IN RANGE");
        }
    }

    private void StartCooldown()
    {
        isOnCooldown = true;
    }
}
