using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool isOpen = false;

    public void ToggleDoor()
    {
        isOpen = !isOpen;
        gameObject.SetActive(!isOpen);
    }
}
