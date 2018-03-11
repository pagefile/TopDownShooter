using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FighterController : ScriptableObject
{
    protected Fighter fighter;

    public virtual void Init(Fighter entity) { entity.Controller = this; }
    public virtual void Update() { }
}
