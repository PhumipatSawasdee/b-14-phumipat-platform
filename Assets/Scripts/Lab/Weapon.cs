using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private int _damage;
    public IShootable shooter;

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

    public void Init(int damage, IShootable owner)
    {
        Damage = damage;
        shooter = owner;
    }

    public abstract void Move();
    public abstract void OnHitWith(Character character);

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
    }

    public int GetShootDirection()
    {
        float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;

        if (shootDir > 0)
        {
            // Right direction
            return 1;
        }
        else return -1; // Left direction
    }
}