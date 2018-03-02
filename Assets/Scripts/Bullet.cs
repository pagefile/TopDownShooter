using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private float Speed = 25.0f;
    [SerializeField]
    private float Damage = 1.0f;
    [SerializeField]
    private float Lifetime = 3.0f;

	// Use this for initialization
	void Start () 
    {
        Rigidbody rbody = GetComponent<Rigidbody>();
        Assert.IsTrue(rbody != null, "Bullet has no rigid body!");
        rbody.velocity = transform.forward * Speed;
        Destroy(gameObject, Lifetime);
	}

    private void OnCollisionEnter(Collision col)
    {
        ExecuteEvents.Execute<IDamageMessageTarget>(col.gameObject, null, (x, y) => x.ApplyDamage(Damage));
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
		
	}
}
