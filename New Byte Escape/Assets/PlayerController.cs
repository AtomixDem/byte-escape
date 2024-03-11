using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocità di movimento del personaggio
    public Rigidbody2D rb; // Riferimento al componente Rigidbody2D del personaggio

    private Vector2 movement; // Vettore per memorizzare l'input di movimento

    void Update()
    {
        // Input da tastiera
        movement.x = Input.GetAxisRaw("Horizontal"); // A e D o frecce sinistra e destra
        movement.y = Input.GetAxisRaw("Vertical"); // W e S o frecce su e giù

        // Normalizza il vettore di movimento per assicurare che il personaggio si muova alla stessa velocità in tutte le direzioni
        movement.Normalize();
    }

    void FixedUpdate()
    {
        // Muove il Rigidbody2D del personaggio basandosi sull'input di movimento
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

