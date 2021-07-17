using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LayerMask platformsLayerMask;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpSpeed;

    private BoxCollider2D boxCollider2d;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        moveSpeed = 5f;
        jumpSpeed = 5f;
    }

    private void Update()
    {
        Move();
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveBy = moveX * moveSpeed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpSpeed;
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }
}
