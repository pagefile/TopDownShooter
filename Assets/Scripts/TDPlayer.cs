using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class TDPlayer : Destructable {

    [SerializeField]
    private float Speed = 20.0f;
    [SerializeField]
    private float GunFireInterval = 0.25f;
    [SerializeField]
    private Bullet BulletType;
    [SerializeField]
    private List<Gun> Level1Guns;
    [SerializeField]
    private List<Gun> Level2Guns;
    [SerializeField]
    private List<Gun> Level3Guns;

    // Live variables
    private int GunLevel = 0;
    private const int MaxGunLevel = 2;
    private float GunDownTime = 0;

    // Delegates
    public delegate void OnDeath();
	
	// Update is called once per frame
	void Update ()
    {
        // Update timing variables
        GunDownTime += Time.deltaTime;

        // Movement
	    if(Input.GetButton("left"))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if(Input.GetButton("right"))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        if(Input.GetButton("up"))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetButton("down"))
        {
            transform.Translate(Vector3.forward * -Speed * Time.deltaTime);
        }
        bool fireGuns = Input.GetButton("primaryFire");

        // Guns
        // TODO: Refactor this. It could just use a list of the lists...as ugly as that sounds
        bool triggerDown = Input.GetButton("primaryFire");
        List<Gun> guns = Level1Guns;
        if(GunLevel == 1)
        {
            guns = Level2Guns;
        }
        else if(GunLevel == 2)
        {
            guns = Level3Guns;
        }
        guns.ForEach(x => x.TriggerDown = triggerDown);
    }
}
