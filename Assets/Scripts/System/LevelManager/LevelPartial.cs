using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pagefile.LevelManagement
{

    [CreateAssetMenu(fileName = "LevelPartial", menuName = "Data/Level partial")]
    public class LevelPartial : ScriptableObject
    {
        public string SceneName;
    }

}