using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb2d;
    private Vector2 force;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Damage = 20;
        force = new Vector2 (2.5f * GetShootDirection(), 10f);
        Move();
    }

    public override void Move()
    {
        rb2d.AddForce(force, ForceMode2D.Impulse);
        //Debug.Log("Rock move with RigitBody: force");
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
    }
}