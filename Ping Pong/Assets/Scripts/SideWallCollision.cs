using System;
using UnityEngine;
using UnityEngine.UI;

public class SideWallCollision : MonoBehaviour
{
    public Text leftScore;
    private int leftPlayerScore = 0;

    public Text rightScore;
    private int rightPlayerScore = 0;

    private float resetDelay = 0.6f;

    public Rigidbody2D rb;

    private Boolean leftScored = false;
    private Boolean rightScored = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "LeftWall")
        {
            Debug.Log("Bounced into left wall");
            rightPlayerScore++;
            rightScore.text = rightPlayerScore.ToString();
            transform.position = new Vector2(1000, 1000);               // transform the ball away from the view
            rightScored = true;                                         // right player scored
            Invoke("ResetPingPongBall", resetDelay);                    // reset the ball position after some seconds
        }

        if (collision.collider.name == "RightWall")
        {
            Debug.Log("Bounced into right wall");
            leftPlayerScore++;
            leftScore.text = leftPlayerScore.ToString();
            transform.position = new Vector2(1000, 1000);               // transform the ball away from the view
            leftScored = true;                                          // left player scored
            Invoke("ResetPingPongBall", resetDelay);                    // reset the ball position after some seconds
        }
    }

    private void ResetPingPongBall()
    {
        rb.velocity = new Vector2(0, 0);                                // reset velocity
        transform.position = new Vector2(0, 0);                         // reset position

        // if left player scored, shoot the ball to left side after reset
        if (rightScored)
        {
            rb.AddForce(new Vector2(300f, 0f));
            rightScored = false;
        }
        // if right player scored, shoot the ball to right side after reset
        else if (leftScored)
        {
            rb.AddForce(new Vector2(-300f, 0f));
            leftScored = false;
        }
    }
}