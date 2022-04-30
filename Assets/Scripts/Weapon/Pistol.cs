using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
   
    public override void Shoot(Transform firePoint)
    {
        print("Pistol Bang");
        Instantiate(this.ammo, firePoint.position, firePoint.rotation);

    }

  
}
