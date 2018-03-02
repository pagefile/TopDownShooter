using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour, IDamageMessageTarget
{
    [SerializeField]
    private float MaxHealth = 100.0f;

    private float currentHealth;
    public float CurrentHealth
    {
        get { return currentHealth; }
    }

    // IDamageMessageTarget
    public void ApplyDamage(float amount, Damage.Type type = Damage.Type.Unknown, GameObject source = null)
    {
        currentHealth -= amount;
        // TODO: Real death handling
        if(currentHealth <= 0.0f)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start ()
    {
        currentHealth = MaxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
