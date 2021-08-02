using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Button))]
public class levelLoader : MonoBehaviour
{
    private Button button;
    public string levelName;
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(onClick);

    }
    private void onClick()
    {
        levelStatus LevelStatus = levelManager.Instance.GetLevelStatus(levelName);
        switch(LevelStatus)
        {
            case levelStatus.Locked:
                Debug.Log("level locked!");
                break;
            case levelStatus.Unlocked:
                SceneManager.LoadScene(levelName);
                break;
            case levelStatus.Completed:
                SceneManager.LoadScene(levelName);
                break;

        }
        
    }
}


