using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    GameObject Bullet { get; set; }
    Transform SpawnPoint { get; set; }
    float ReloadTime { get; set; }
    float WaitTime { get; set; }

    void Shoot();
}
