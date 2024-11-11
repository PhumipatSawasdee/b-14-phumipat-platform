using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthImage;

    private int _maxHealth;

    public void SetMaxHealth(int health)
    {
        _maxHealth = health;
    }

    public void HealthUpdate(int health)
    {
        healthImage.fillAmount = (float)health / (float)_maxHealth;
    }
}