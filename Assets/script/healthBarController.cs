using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class healthBarController : MonoBehaviour
{
    public Image healthBarImage;
    public playerController player;
    public gameOverController GameOverController;
    public void updateHealthBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp(player.health / player.maxHealth, 0, 1f);
    }

    private void Update()
    {
        if(healthBarImage.fillAmount==0)
        {
            GameOverController.playerDied();
            player.enabled = false;
        }
    }
}
