using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("Speed at which the object moves downward")]
    public float moveSpeed = 5.0f;

    [Tooltip("Y position at which the object will be destroyed")]
    public float destroyYBound = -10.0f;

    void Update()
    {
        // Move the object straight down over time
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // Destroy the object when it goes past the bottom boundary
        if (transform.position.y < destroyYBound)
        {
            Destroy(gameObject);
        }
    }
}