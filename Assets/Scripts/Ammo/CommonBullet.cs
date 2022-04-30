using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonBullet : Ammo
{
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject,5f);
        rb.velocity = transform.right * this.ammoStats.speed;
    }

   
  
}
