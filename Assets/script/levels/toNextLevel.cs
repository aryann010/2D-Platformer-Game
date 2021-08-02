using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class toNextLevel : MonoBehaviour
{
    public Button button;
    private void Awake()
    {
        button.onClick.AddListener(loadNextLevel);
    }
    private void loadNextLevel()
    {
        int cIndex = levelManager.Instance.markLevelComplete();
        SceneManager.LoadScene(cIndex+1);
    }
}
