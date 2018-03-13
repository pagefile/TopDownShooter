using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FighterController : ScriptableObject
{
    protected Fighter fighter;

    public virtual void Init(Fighter entity)
    {
        entity.Controller = this;
        fighter = entity;
    }

    public virtual void Reset()
    {
        fighter = null;
    }

    public abstract void Update();

}
