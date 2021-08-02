using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOverController : MonoBehaviour
{
    public Button restartButton;
    public Button quitButton;
   
    

   
    

    private void Awake()
    {
        restartButton.onClick.AddListener(reloadLevel);
        quitButton.onClick.AddListener(returnLobby);
      
       
    }
    public void playerDied()
    {
        gameObject.SetActive(true);
    }
    
   

    private void reloadLevel()
    {
        int cIndex = levelManager.Instance.markLevelComplete();
        SceneManager.LoadScene(cIndex);
    }
    private void returnLobby()
    {
        SceneManager.LoadScene(3);
        
    }
    
}
