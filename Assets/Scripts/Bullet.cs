using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private float Speed = 25.0f;
    [SerializeField]
    private float Damage = 1.0f;

	// Use this for initialization
	void Start () 
    {
        Rigidbody rbody = GetComponent<Rigidbody>();
        Assert.IsTrue(rbody != null, "Bullet has no rigid body!");
        rbody.velocity = Vector3.forward * Speed;
	}
	
	// Update is called once per frame
	void Update()
    {
		
	}
}
