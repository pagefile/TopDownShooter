using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Destroyed!");
        Destroy(col.gameObject);
    }
}
