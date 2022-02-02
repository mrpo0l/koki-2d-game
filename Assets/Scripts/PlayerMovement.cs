using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce;
    public bool moving;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    PlayerAnim playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerAnim = GetComponent<PlayerAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        moving = Input.GetAxisRaw("Horizontal")  != 0;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            playerAnim.TriguerJump();
        }

        spriteRenderer.flipX = (Input.GetAxisRaw("Horizontal") == -1);
    }

    private void FixedUpdate() {
        Vector2 newVelocity;
        newVelocity.x = Input.GetAxisRaw("Horizontal") * movementSpeed;
        newVelocity.y = rb.velocity.y;

        rb.velocity = newVelocity;
    }
}
