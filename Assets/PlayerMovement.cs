using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 20f;
    public float movementSmoothing = 0.05f;
    
    private Rigidbody2D rigidbody2D;
    private float horizontalMove = 0f;
    private Vector3 currentVelocity;
    private float compensationSpeed = 10f;
    private bool facingRight = true;
    private bool jumpPressed = false;
    private bool isGrounded = false;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed * compensationSpeed;

    }

    private void FixedUpdate()
    {
        Vector3 targetVelocity = new Vector3(horizontalMove, Time.fixedDeltaTime, rigidbody2D.velocity.y);
        rigidbody2D.velocity = Vector3.SmoothDamp(rigidbody2D.velocity, targetVelocity, ref currentVelocity, movementSmoothing);

        if(horizontalMove > 0f && !facingRight)
        {
            facingRight = !facingRight;
            Vector3 targetScale = transform.localScale;
            targetScale.x *= -1;
            transform.localScale = targetScale;
        }
        else if(horizontalMove < 0f && facingRight)
        {
            facingRight = !facingRight;
            Vector3 targetScale = transform.localScale;
            targetScale.x *= -1;
            transform.localScale = targetScale;
        }
    }
}
