using UnityEngine;

public class LeftPlayer : MonoBehaviour
{
    public float speed = 10;
    private Vector2 move = new Vector2(0, 1);

    //public Rigidbody2D rb2D;

    private void Update()
    {
        if (Input.GetKey("w"))
            transform.Translate(move * speed * Time.deltaTime);

        if (Input.GetKey("s"))
            transform.Translate(move * -speed * Time.deltaTime);
    }
}