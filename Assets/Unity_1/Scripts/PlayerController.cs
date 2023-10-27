using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float movementScale = 10.0f;
    private float xMovement = 0.0f;
    private bool shouldJump;
    [SerializeField]
    private float jumpForce;

    [field: SerializeField]
    public int health {  get; private set; }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal");
        shouldJump |= Input.GetKeyDown(KeyCode.Space);
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector2.right * xMovement * movementScale, ForceMode2D.Force);

        bool isGrounded = Physics2D.ov
        if(shouldJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            shouldJump = false;
        }
    }
}
