using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private float _speed;

    private void Start()
    {
        Damage = 30;
        _speed = 4f;

        Move();
    }

    public override void Move()
    {
        Debug.Log("Banana move with constant speed by Tranform");
    }

    public override void OnHitWith(Character character)
    {
        
    }
}
