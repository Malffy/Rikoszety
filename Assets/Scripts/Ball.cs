using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    void LaunchBall()
    {
        Vector2 initialDirection = new Vector2(1, Random.Range(-1f, 1f)).normalized;
        rb.velocity = initialDirection * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Normalizacja prędkości po odbiciu
        rb.velocity = rb.velocity.normalized * speed;

        // Korekcja kąta, aby nie był zbyt płaski
        if (Mathf.Abs(rb.velocity.y) < 0.5f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y > 0 ? 0.5f : -0.5f).normalized * speed;
        }
    }
}
