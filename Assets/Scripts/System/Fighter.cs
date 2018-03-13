using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Destructable
{
    #region Serialized Editor Variables
    [SerializeField]
    private float MaxMoveSpeed = 10.0f;
    [SerializeField]
    private Transform GunHardpoint;
    [SerializeField]
    public FighterController Controller;
    [SerializeField]
    private Gun DefaultWeapon;
    #endregion

    #region Member Variables
    private Vector3 movementAxis;
    private Gun ActiveGun;
    #endregion

    #region Controls
    public void MovementAxis(float vertical, float horizontal)
    {
        movementAxis.x = horizontal;
        movementAxis.z = vertical;
    }

    public void FireingGuns(bool fire)
    {
        ActiveGun.TriggerDown = fire;
    }
    #endregion

    #region Unity Functions
    // Use this for initialization
    protected override void Start ()
    {
        base.Start();
        movementAxis = new Vector3();
        ActiveGun = Instantiate(DefaultWeapon, GunHardpoint.position, GunHardpoint.rotation, GunHardpoint);
    }
	
    // Update is called once per frame
    protected virtual void Update ()
    {
        Controller.Update();
        transform.Translate(movementAxis * MaxMoveSpeed * Time.deltaTime);
    }

    protected virtual void OnDestroy()
    {
        Controller.Reset();
    }
    #endregion
}