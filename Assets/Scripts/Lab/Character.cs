using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // Attribute [SerializeField] : Show var to unity
    [SerializeField] private int _health;
    private int _maxHealth;

    [SerializeField] GameObject HealthSprite;

    public int Health 
    {  
        get 
        { 
            return _health;
        }
        set 
        {
            _health = value;
        }
    }
    public Animator anim;
    public Rigidbody2D rb;

    public bool IsDead()
    {
        return Health <= 0;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        HealthSprite.transform.localScale = new Vector2((float)Health / (float)_maxHealth, .1f);

        Debug.Log($"Current Health : {Health}");
        IsDead();
    }

    public void Init(int newHealth)
    {
        Health = newHealth;
        _maxHealth = Health;
        HealthSprite.transform.localScale = new Vector2((float)Health / (float)_maxHealth, .1f);
    }
}