using UnityEngine;

public class CollisionWithPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 400f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int x = Random.Range(0, 4);

        if (collision.collider.name == "Left Player" || collision.collider.name == "Right Player")
        {
            if (x == 0)
            {
                rb.velocity = new Vector2(0, 0); // reset velocity
                rb.AddForce(new Vector2(speed, speed)); // add some force to vector2
            }
            else if (x == 1)
            {
                rb.velocity = new Vector2(0, 0);
                rb.AddForce(new Vector2(-speed, -speed));
            }
            else if (x == 2)
            {
                rb.velocity = new Vector2(0, 0);
                rb.AddForce(new Vector2(speed, -speed));
            }
            else if (x == 3)
            {
                rb.velocity = new Vector2(0, 0);
                rb.AddForce(new Vector2(-speed, speed));
            }
        }
    }
}