using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour, IDamageMessageTarget
{
    [SerializeField]
    private float MaxHealth = 100.0f;

    private float currentHealth;
    public float CurrentHealth
    {
        get { return currentHealth; }
    }

    // IDamageMessageTarget
    public virtual void ApplyDamage(float amount, Damage.Type type = Damage.Type.Unknown, GameObject source = null)
    {
        currentHealth -= amount;
        // TODO: Real death handling
        if(currentHealth <= 0.0f)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    public virtual void Start ()
    {
        currentHealth = MaxHealth;
    }
}
