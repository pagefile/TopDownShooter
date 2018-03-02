using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IDamageMessageTarget : IEventSystemHandler
{
    void ApplyDamage(float amount, Damage.Type type = Damage.Type.Unknown, GameObject source = null);
}
