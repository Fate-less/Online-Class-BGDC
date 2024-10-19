using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float launchSpeed = 10f; // Set a speed for the ball
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    public void ResetPosition()
    {
        gameObject.transform.position = new Vector2(0, 0);
    }

    void LaunchBall()
    {
        // Randomize the initial direction (left or right)
        float randomDirection = Random.Range(0, 2) == 0 ? -1f : 1f;

        // Set the velocity of the ball in a random direction (up and to the side)
        rb.velocity = new Vector2(randomDirection, Random.Range(-1f, 1f)).normalized * launchSpeed;
    }
}
