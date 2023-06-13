using UnityEngine;

public class BallBouncingMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float initialSpeed = 300f;

    private void Start()
    {
        int x = Random.Range(0, 2);

        if (x == 0)
            rb.AddForce(new Vector2(initialSpeed, 0f));
        else if (x == 1)
            rb.AddForce(new Vector2(-initialSpeed, 0f));
    }
}