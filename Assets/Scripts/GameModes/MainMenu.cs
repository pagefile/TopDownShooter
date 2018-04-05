using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pagefile.LevelManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private LevelInfo StartScene;
    
    public void OnStartClick()
    {
        // Start game lol
        LevelLoader.LoadLevel(StartScene);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
