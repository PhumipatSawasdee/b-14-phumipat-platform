using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb2d;
    private Vector2 force;

    private void Start()
    {
        Damage = 40;

        Move();
    }

    public override void Move()
    {
        Debug.Log("Rock move with RigitBody: force");
    }

    public override void OnHitWith(Character character)
    {

    }
}