using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemySpawner : MonoBehaviour 
{
    [SerializeField]
    private GameObject SpawnEnemey;
    [SerializeField]
    private uint NumberToSpawn = 10;
    [SerializeField]
    private float SpawnInterval = 3.0f;
    [SerializeField]
    private float Radius = 0.0f;

    float spawnDownTime = 0.0f;

	// Use this for initialization
	void Start()
    {
		
	}
	
	// Update is called once per frame
	void Update() 
    {
        spawnDownTime += Time.deltaTime;
        if(spawnDownTime >= SpawnInterval)
        {
            spawnDownTime = 0.0f;
            float range = Random.Range(-Radius, Radius);
            Instantiate(SpawnEnemey, new Vector3(range, transform.position.y, transform.position.z), transform.rotation);
        }
	}
}
