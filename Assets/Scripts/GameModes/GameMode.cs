using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    // TODO: HACK
    [SerializeField]
    private TDPlayer Player;
    [SerializeField]
    private Text HealthText;
    [SerializeField]
    TDPlayer PlayerShip;
    [SerializeField]
    Transform SpawnPoint;
    [SerializeField]
    float RespawnTime;

    private float spawnTimer = 0;
    private uint Score;
    TDPlayer activePlayer;

	// Use this for initialization
	void Start ()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
	}
	
	// Update is called once per frame
	void Update ()
    {
        // SUPERHACK: Really I should hook into an OnDeath event from the player...but I want this now
        if(GameObject.Find("TDFighterRoot(Clone)") == null)
        {
            spawnTimer -= Time.deltaTime;
            if(spawnTimer <= 0.0f)
            {
                activePlayer = Instantiate(PlayerShip, SpawnPoint.position, SpawnPoint.rotation);
                spawnTimer = RespawnTime;
                //player.OnDeath += OnPlayerDeath;
            }
        }
	}

    private void LateUpdate()
    {
        HealthText.text = "Health: " + activePlayer.CurrentHealth.ToString();
    }

    void OnPlayerDeath()
    {

    }
}
