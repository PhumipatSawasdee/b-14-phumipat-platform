using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform SpawnPoint { get; set; }

    [field: SerializeField] public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    private void Start()
    {
        Init(100);
        Debug.Log($"Player Health : {Health}");
    }

    private void Update()
    {
        Shoot();
    }

    private void FixedUpdate()
    {
        WaitTime -= Time.deltaTime;
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && (WaitTime <= 0f))
        {
            GameObject bulletObject = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            Destroy(bulletObject, 2f);
            Banana banana = bulletObject.GetComponent<Banana>();
            banana.Init(30, this);

            WaitTime = ReloadTime;
        }
    }

    public void OnHitWith(Enemy enemy)
    {
        if (enemy is Enemy)
        {
            TakeDamage(20);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Enemy>());
    }
}
