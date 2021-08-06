
using UnityEngine;
using UnityEngine.UI;


public class lobbyController : MonoBehaviour
{
    public Button playButton;
    public GameObject levelSelection;
    private void Awake()
    {
        playButton.onClick.AddListener(level1); 
    }
    private void level1()
    {
        levelSelection.SetActive(true);
    }
}
