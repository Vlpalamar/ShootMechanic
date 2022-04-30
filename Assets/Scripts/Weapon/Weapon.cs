using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    protected WeaponStats stats;
    [SerializeField]
    protected Ammo ammo;

    private Transform firePoint;

    public Transform FirePoint
    {
        get { return firePoint; }
        set { firePoint = value; }
    }

    public virtual void Shoot(Transform FirePoint )
    {
        Debug.Log("bang");
    }

    public virtual bool IsAuto( )
    {
        if (stats.isAuto)
            return true;
        else
            return false;
    }

    public virtual float SetDeley()
    {
        return stats.deley;
    }

    public virtual Sprite SetSprite(Sprite sprite= null)  //виртуальный на всякий случай если в будующем методы будут переопределяться  на данном этапе это не обязательно 
    {
        return stats.CharacterSprite;
    }

}
