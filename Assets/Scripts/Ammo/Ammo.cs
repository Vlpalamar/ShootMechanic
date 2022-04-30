using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ammo : MonoBehaviour
{
    [SerializeField]
    protected AmmoStats ammoStats;

    protected Rigidbody2D rb;
 
    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        //проверка на нужные коллизии
        //анимация попадания 
        if (!other.tag.Equals("Player"))
        {
            print("xyi");
            Destroy(this.gameObject);
        }
        
    }


}
