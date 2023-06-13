using UnityEngine;

public class RightPlayer : MonoBehaviour
{
    private float speed = 10;
    private Vector2 move = new Vector2(0, 1);


    private void Update()
    {
        if (Input.GetKey("up"))
            transform.Translate(move * speed * Time.deltaTime);
        if (Input.GetKey("down"))
            transform.Translate(move * -speed * Time.deltaTime);
    }
}