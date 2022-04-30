using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autorifle : Weapon
{
    public override void Shoot(Transform firePoint)
    {
        print("Auto Bang");
          Instantiate(this.ammo, firePoint.position, firePoint.rotation);
    }
}
