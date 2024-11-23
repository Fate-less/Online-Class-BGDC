using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float launchSpeed = 10f; // Set a speed for the ball
    public float speedIncrease;
    private Rigidbody2D rb;
    public float newVelocityX;
    public float newVelocityY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    public void ResetPosition()
    {
        transform.position = new Vector3(0,0,0);
        LaunchBall();
    }

    void LaunchBall()
    {
        // Randomize the initial direction (left or right)
        float randomDirection = Random.Range(0, 2) == 0 ? -1f : 1f;

        // Set the velocity of the ball in a random direction (up and to the side)
        rb.velocity = new Vector2(randomDirection, Random.Range(-1f, 1f)).normalized * launchSpeed;
    }

    public void SpeedIncreaseOnParry()
    {
        Vector2 newVelocity = rb.velocity.normalized;
        float newSpeed = rb.velocity.magnitude + speedIncrease;
        rb.velocity = newVelocity * newSpeed;
    }
}
