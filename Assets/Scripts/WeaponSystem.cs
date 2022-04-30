using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    private SpriteRenderer sr;

    List<Weapon> weapons;
    private Weapon currentWeapon;
    private bool isAuto;
    private float deley=0.1f;


    [SerializeField]
    private Transform firePoint;
    void Start()
    {
        weapons = new List<Weapon>();
        sr = GetComponent<SpriteRenderer>();
    }

    private float currDeley=0; //флаг что бы 
    void Update()
    {
        if (isAuto)
        {
            if (Input.GetButton("Fire1") && currDeley<=0)
            {
                currentWeapon.Shoot(firePoint);
                currDeley = deley;
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire1") && currDeley <= 0)
            {
                currentWeapon.Shoot(firePoint);
                currDeley = deley;
            }
        }

      
        
      
        
    }

    void FixedUpdate()
    {
        currDeley -= Time.fixedDeltaTime;
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Weapon>())
        {
            print("got it");
            Weapon weapon = other.GetComponent<Weapon>();
            weapons.Add(weapon);
            TakeWeapon(weapons.Count-1);
            Destroy(other.gameObject);

        }

    }

    private void TakeWeapon(int idex= 0)
    {
        currentWeapon = weapons[idex];
        isAuto = currentWeapon.IsAuto();
        deley = currentWeapon.SetDeley();
        sr.sprite = currentWeapon.SetSprite();

    }

}
