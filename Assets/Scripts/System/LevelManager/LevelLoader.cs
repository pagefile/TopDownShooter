using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pagefile.LevelManagement
{

    public static class LevelLoader
    {
        #region Member functions
        public static void LoadLevel(LevelInfo level)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            // TODO: Add a loading screen
            SceneManager.LoadScene(level.SceneName, LoadSceneMode.Single);
            foreach(LevelPartial p in level.Dependencies)
            {
                SceneManager.LoadScene(p.SceneName, LoadSceneMode.Additive);
            }
        }
        #endregion
    }

}