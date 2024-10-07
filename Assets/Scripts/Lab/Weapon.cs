using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private int _damage;
    public int Damage
    {
        get 
        { 
            return _damage;
        }
        set 
        {
            _damage = value;
        }
    }

    protected string owner;
    public abstract void Move();
    public abstract void OnHitWith(Character character);

    public int GetShootDirection()
    {
        return 1;
    }
}