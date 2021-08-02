using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class levelCompleted : MonoBehaviour
{
    public gameOverController gameOverController;
    public toNextLevel toNextLevel;
    
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {



            // SceneManager.LoadScene(0);
            levelManager.Instance.markLevelComplete();
            gameOverController.gameObject.SetActive(true);
            toNextLevel.gameObject.SetActive(true);

            

        }
    }
}
