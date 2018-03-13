using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BasicEnemyController", menuName = "Controllers/BasicEnemy", order = 1)]
public class BasicEnemyController : FighterController
{
    #region Overrides
    public override void Init(Fighter entity)
    {
        base.Init(entity);
    }

    public override void Update()
    {
        fighter.MovementAxis(1.0f, 0.0f);
        fighter.FireingGuns(true);
    }
    #endregion
}
