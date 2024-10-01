using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;

    private void Start()
    {
        Init(10);
        Debug.Log($"Ant Health : {Health}");

        Behaviour();
    }

    private void FixedUpdate()
    {
        Behaviour();
    }

    public override void Behaviour()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        // Set if ant position when ant move pass
        if ((rb.position.x <= movePoints[0].position.x && velocity.x < 0) || (rb.position.x >= movePoints[1].position.x && velocity.x > 0))
        {
            Flip();
        }
    }

    // Flip ant sprite
    private void Flip()
    {
        velocity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}