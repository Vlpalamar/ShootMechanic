using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/WeaponStats", order = 0)]
public class WeaponStats : ScriptableObject
{
    public Sprite CharacterSprite;
    public float deley;
    public bool isAuto;

}
