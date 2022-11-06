using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    // 人物移动速度
    public float moveSpeed = 3.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var moveX = Input.GetAxis("Horizontal");
        var moveY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, moveY * moveSpeed);
    }
}
