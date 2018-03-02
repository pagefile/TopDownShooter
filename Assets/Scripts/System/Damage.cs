using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage
{
    public enum Type
    {
        Unknown,
        Bullet,
        AP,
        Explosive,
        Energy,
        World,
    };

    public Type DamageType = Type.Unknown;
    public float DamageAmount = 1.0f;
}
