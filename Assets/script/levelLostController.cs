using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLostController : MonoBehaviour
    
{
    public gameOverController gameOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            gameOver.playerDied();
            
        }
    }
}
