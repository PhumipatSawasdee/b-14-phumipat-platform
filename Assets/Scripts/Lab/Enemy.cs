using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    private int _damageHit;
    public int DamageHit
    {
        get
        {
            return _damageHit;
        }
        set 
        {
            _damageHit = value;
        }
    }

    private void Start()
    {
        Behaviour();
    }

    public abstract void Behaviour();
}