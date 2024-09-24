using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodie : Enemy
{
    private float _attackRange;
    private Player player;

    public void Shoot()
    {

    }

    public override void Behaviour()
    {
        Debug.Log("Croccodie.Behaviour");
    }
}