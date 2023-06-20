using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    public void FixedUpdate()
    {
        if(ball.velocity.x > 0f) // ball is moving towards computer paddle
        {
            if(ball.position.y > rb.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }
            else if (ball.position.y < rb.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
        }
        else if (ball.velocity.y > 0f) // ball is moving away from  computer paddle
        {
            if (ball.position.y > rb.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if (ball.position.y < rb.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}
