using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformToggle : MonoBehaviour
{
    [SerializeField]
    private List<RuntimePlatform> Platforms;

    // Use this for initialization
    void Start ()
    {
        bool active = false;
        // Could...self destroy here? Seems weird. Just SetActive(false) for now
        for(int i = 0; i < Platforms.Count; i++)
        {
            if(Platforms[i] == Application.platform)
            {
                active = true;
                break;
            }
        }
        gameObject.SetActive(active);
    }

}
