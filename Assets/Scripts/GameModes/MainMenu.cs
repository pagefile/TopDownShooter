using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private string StartScene;
    
    public void OnStartClick()
    {
        // Start game lol
        SceneManager.LoadScene(StartScene);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
