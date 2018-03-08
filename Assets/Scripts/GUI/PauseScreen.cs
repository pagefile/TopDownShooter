using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    private GameMode gameMode;

    public void Init(GameMode gm)
    {
        gameMode = gm;
    }

    public void OnResumeClick()
    {
        gameMode.UnpauseGame();
    }

    public void OnMainMenuClick()
    {
        gameMode.OnMainMenuClick();
    }
}
