using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour
{
    // Reference to the game object to be deactivated
    public GameObject gameObjectToDeactivate;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("IS TOUCHING");
        // Check if the game object is deactivated and if the collider is the player
        if (!gameObjectToDeactivate.activeSelf && other.CompareTag("Player"))
        {
            // Load the next scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void Update() {
        
    }
}
