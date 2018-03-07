using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class BasicEnemy : Destructable
{
    [SerializeField]
    private float Speed = 10.0f;
    [SerializeField]
    private float FireInterval = 1.0f;
    [SerializeField]
    private Transform GunPoint;
    [SerializeField]
    private Bullet BulletType;

    // TODO: Make gun component to encapsulate all this
    private float GunDownTime = 0;

	// Use this for initialization
	override public void Start()
    {
        base.Start();
        // Check for necessary components
        Assert.IsTrue(GunPoint != null, "No gunpoint specified on enemy!");
        Assert.IsTrue(BulletType != null, "No bullet type specified on enemy!");
	}
	
	// Update is called once per frame
	void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        GunDownTime += Time.deltaTime;
        if(GunDownTime >= FireInterval)
        {
            GunDownTime = 0.0f;
            Instantiate(BulletType, GunPoint.position, GunPoint.rotation);
        }
	}
}
