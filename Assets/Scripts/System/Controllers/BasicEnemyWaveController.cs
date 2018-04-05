using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BasicEnemyController", menuName = "Controllers/WaveEnemy", order = 2)]
public class BasicEnemyWaveController : FighterController
{
    [SerializeField]
    private float Frequency = 1.0f;

    private float time = 0.0f;

    #region Overrides
    public override void Init(Fighter entity)
    {
        base.Init(entity);
    }

    public override void Update()
    {
        time += Time.deltaTime;
        fighter.MovementAxis(1.0f, Mathf.Sin(time * Frequency));
        fighter.FireingGuns(true);
    }
    #endregion
}
