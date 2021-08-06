using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    private static levelManager instance;
    public static levelManager Instance { get { return instance; } }
    //public string[] levels;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // private void Start()
    // {
    //    if (GetLevelStatus(levels[0])== levelStatus.Locked)
    //   {
    //      SetLevelStatus(levels[0], levelStatus.Unlocked);
    //  }
    //  }

    public int markLevelComplete()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        int nextSceneIndex = currentScene.buildIndex;
        // SetLevelStatus(currentScene.name, levelStatus.Completed);

        //int currentSceneIndex = Array.FindIndex(levels, level => level == currentScene.name);

        //int nextSceneIndex = currentSceneIndex + 1;
        //if(nextSceneIndex<levels.Length)
        //{
        //    SetLevelStatus(levels[nextSceneIndex], levelStatus.Unlocked);
        //}
        return nextSceneIndex;
    }
}

   

    //public levelStatus GetLevelStatus(string level)
    //{
   //     levelStatus LevelStatus = (levelStatus)PlayerPrefs.GetInt(level, 0);
    //    return LevelStatus;
   // }
   // public void SetLevelStatus(string level,levelStatus LevelStatus)
   // {
   //     PlayerPrefs.SetInt(level, (int)LevelStatus);
   // }
//}
