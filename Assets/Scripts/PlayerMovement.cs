using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    public float speed = 5.0f; // Zwiększ prędkość, jeśli potrzeba
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Pobranie wejścia użytkownika
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // Użycie "Input.GetAxisRaw" dla ostrzejszej reakcji

        // Ustawienie prędkości (reset przed ruchem)
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }
}
