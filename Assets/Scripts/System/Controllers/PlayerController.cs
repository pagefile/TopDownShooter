using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : FighterController
{
    #region Overrides
    public override void Init(Fighter entity)
    {
        base.Init(entity);
        fighter = entity;
    }

    public override void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool firing = Input.GetButton("primaryFire");
        fighter.FireingGuns(firing);
        fighter.MovementAxis(vertical, horizontal);
    }
    #endregion
}
