using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    [SerializeField]
    PauseScreen PauseScreen;

    private float spawnTimer = 0;
    private uint Score;
    private TDPlayer activePlayer;
    private bool gamePaused = false;

    PauseScreen pauseScreenInstance;

	// Use this for initialization
	void Start ()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
        pauseScreenInstance = Instantiate(PauseScreen);
        // TODO: Pause screen should manage its own active state
        pauseScreenInstance.gameObject.SetActive(false);
        pauseScreenInstance.Init(this);
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

        // HACK: Need an input handler somewhere
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!gamePaused)
            {
                PauseGame();
            }
            else
            {
                UnpauseGame();
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

    public void PauseGame()
    {
        gamePaused = !gamePaused;
        Time.timeScale = 0.0f;
        pauseScreenInstance.gameObject.SetActive(true);
    }

    public void UnpauseGame()
    {
        gamePaused = !gamePaused;
        Time.timeScale = 1.0f;
        pauseScreenInstance.gameObject.SetActive(false);
    }

    // Should probably be handled else where, but this will work for now
    public void OnMainMenuClick()
    {
        // TODO: Find a good place to put this.
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }
}
