
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class lobbyController : MonoBehaviour
{
    public Button playButton;
    public GameObject levelSelector;
    private void Awake()
    {
        playButton.onClick.AddListener(storyline); 
    }
    private void storyline()
    {
        soundManager.Instance.play(sounds.buttonClick);
       
        levelSelector.SetActive(true);
    }
}
