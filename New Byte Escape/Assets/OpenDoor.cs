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

    private void ShowInteract()
    {
        containerObject.SetActive(true);
    }

    private void HideInteract()
    {
        containerObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            ShowInteract();
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
        else
        {
            HideInteract();
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
}
