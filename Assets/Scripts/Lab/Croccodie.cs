using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodie : Enemy, IShootable
{
    [SerializeField] private float _attackRange;
    public Player player;

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform SpawnPoint { get; set; }

    [field: SerializeField] public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    private void Start()
    {
        Init(30);
        Debug.Log($"Croccodie Health : {Health}");

        Behaviour();
        TakeDamage(10);
    }

    private void FixedUpdate()
    {
        WaitTime -= Time.deltaTime;

        Behaviour();

        if (WaitTime < 0f)
        {
            WaitTime = ReloadTime;
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

    public void Shoot()
    {
        if (WaitTime <= 0f)
        {
            // Instantiate : Clone object with base object
            // Instantiate is overload method it's can use a lot of form
            GameObject bulletObject = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            Destroy(bulletObject, 2f);
        }
    }
}