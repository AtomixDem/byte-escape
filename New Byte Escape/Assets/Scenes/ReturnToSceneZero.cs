using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToSceneZero : MonoBehaviour
{
    // Metodo chiamato all'avvio dello script

    // Metodo chiamato ad ogni frame dell'aggiornamento
    void Update()
    {
        // Verifica se il tasto Invio è stato premuto
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Carica la prima scena nell'elenco delle scene in build
            SceneManager.LoadScene(0);
        }
    }
}
