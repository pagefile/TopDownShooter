using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class TDPlayer : MonoBehaviour {

    [SerializeField]
    private float Speed = 20.0f;
    [SerializeField]
    private float GunFireInterval = 0.25f;
    [SerializeField]
    private Bullet BulletType;
    [SerializeField]
    private List<Transform> Level1Guns;
    [SerializeField]
    private List<Transform> Level2Guns;
    [SerializeField]
    private List<Transform> Level3Guns;

    // Live variables
    private int GunLevel = 0;
    private const int MaxGunLevel = 2;
    private float GunDownTime;

	// Use this for initialization
	void Start ()
    {

	}
	
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

        // Guns
        // TODO: Refactor this. It could just use a list of the lists...as ugly as that sounds
        if(Input.GetButton("primaryFire") && GunDownTime >= GunFireInterval)
        {
            GunDownTime = 0.0f;
            List<Transform> guns = null;
            if (GunLevel == 0)
            {
                guns = Level1Guns;
            }
            else if(GunLevel == 1)
            {
                guns = Level2Guns;
            }
            else if(GunLevel == 2)
            {
                guns = Level3Guns;
            }
            if(guns == null)
            {
                // something fucked up. Really just wanna get rid of the warning though;
                return;
            }
            for (int i = 0; i < guns.Count; i++)
            {
                Instantiate(BulletType, guns[i].position, guns[i].rotation);
            }
        }
    }
}
