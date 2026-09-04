using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // ห้ามหมุน
        rb.constraints =
            RigidbodyConstraints.FreezePositionZ |
            RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        float input = 0f;

        if (Keyboard.current.aKey.isPressed)
            input = -1f;

        if (Keyboard.current.dKey.isPressed)
            input = 1f;

        Vector3 velocity = rb.linearVelocity;

        velocity.x = input * moveSpeed;
        velocity.z = 0f;

        rb.linearVelocity = velocity;
    }
}