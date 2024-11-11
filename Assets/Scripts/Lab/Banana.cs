using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private float _speed;

    private void Start()
    {
        Damage = 30;
        _speed = 4f * GetShootDirection();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public override void Move()
    {
        float newX = transform.position.x + _speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;

        //Debug.Log("Banana move with constant speed by Tranform");
    }

    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);
        }
    }
}
