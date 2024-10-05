using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 10f; // Speed of the paddle movement
    public float boundaryY = 4f; // Y boundary for paddle movement

    public KeyCode upKey; // Key for moving up
    public KeyCode downKey; // Key for moving down

    void Update()
    {
        // Movement input based on specified keys
        float moveInput = 0;

        if (Input.GetKey(upKey))
        {
            moveInput = 1; // Move up
        }
        else if (Input.GetKey(downKey))
        {
            moveInput = -1; // Move down
        }

        // Calculate movement
        Vector2 movement = new Vector2(0, moveInput) * speed * Time.deltaTime;

        // Move paddle
        transform.Translate(movement);

        // Clamp the paddle's position to stay within boundaries
        float clampedY = Mathf.Clamp(transform.position.y, -boundaryY, boundaryY);
        transform.position = new Vector2(transform.position.x, clampedY);
    }
}
