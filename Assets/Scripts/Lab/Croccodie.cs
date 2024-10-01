using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodie : Enemy
{
    [SerializeField] private float _attackRange;
    public Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;

    [SerializeField] private float bulletSpawnTime;
    [SerializeField] private float bulletTimer;

    private void Update()
    {
        bulletTimer -= Time.deltaTime;

        Behaviour();

        if (bulletTimer < 0f)
        {
            bulletTimer = bulletSpawnTime;
        }
    }

    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        // .magnitude use only distance not use direction
        float distance = direction.magnitude;

        if (distance < _attackRange)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (bulletTimer <= 0)
        {
            // Instantiate : Clone object with base object
            // Instantiate is overload method it's can use a lot of form
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        }
    }
}