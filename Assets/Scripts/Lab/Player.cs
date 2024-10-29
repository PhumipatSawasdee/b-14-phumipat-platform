using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform SpawnPoint { get; set; }

    [field: SerializeField] public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

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

            WaitTime = ReloadTime;
        }
    }

    public void OnHitWith(Enemy enemy)
    {

    }
}
