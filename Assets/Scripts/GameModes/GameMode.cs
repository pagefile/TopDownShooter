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

    private uint Score;

	// Use this for initialization
	void Start ()
    {
        Random.InitState(20);
	}
	
	// Update is called once per frame
	void Update ()
    {
        HealthText.text = "Health: " + Player.GetComponent<HealthBar>().CurrentHealth.ToString();
	}
}
