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
        soundManager.Instance.play(sounds.playerDeath);
        gameObject.SetActive(true);
    }
    
   

    private void reloadLevel()
    {
        int nIndex = levelManager.Instance.markLevelComplete();
        SceneManager.LoadScene(nIndex-1);
    }
    private void returnLobby()
    {
        SceneManager.LoadScene(0);
        
    }
    
}
