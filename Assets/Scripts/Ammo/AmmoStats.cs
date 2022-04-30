using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AmmoStats", order = 1)]
public class AmmoStats : ScriptableObject
{
    public float damage;
    public float speed;
}
