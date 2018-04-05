using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pagefile.LevelManagement
{

    [CreateAssetMenu(fileName = "LevelInfo", menuName = "Data/Level info")]
    public class LevelInfo : ScriptableObject
    {
        [Tooltip("Name of the scene to load")]
        public string SceneName;
        [Tooltip("Levels to load as part of this level")]
        public LevelPartial[] Dependencies;
    }

}