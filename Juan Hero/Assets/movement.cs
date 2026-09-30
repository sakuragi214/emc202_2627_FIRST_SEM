using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * move * speed * Time.deltaTime);
    }
}