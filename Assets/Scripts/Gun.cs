using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Transform MuzzlePoint;
    [SerializeField]
    private float FireInterval = 1.0f;
    [SerializeField]
    private Bullet Projectile;

    private float gunDownTime = 0.0f;
    private bool triggerDown = false;

    public bool TriggerDown
    {
        get { return triggerDown; }
        set { triggerDown = value; }
    }

	// Use this for initialization
	void Start ()
    {
        Assert.IsNotNull(MuzzlePoint, "Muzzle point is not set!");
        Assert.IsNotNull(MuzzlePoint, "Projecitle is now set!");
        gunDownTime = FireInterval;
	}
	
	// Update is called once per frame
	void Update ()
    {
        gunDownTime += Time.deltaTime;
        if(gunDownTime >= FireInterval && triggerDown)
        {
            gunDownTime = 0.0f;
            Instantiate(Projectile, MuzzlePoint.transform.position, MuzzlePoint.transform.rotation);
        }
	}
}
