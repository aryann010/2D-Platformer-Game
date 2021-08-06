using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storyLineController : MonoBehaviour
{
    public Button proceedButton;
    public GameObject levelSelector;
    private void Awake()
    {
        proceedButton.onClick.AddListener(storyline);
    }
    private void storyline()
    {
        soundManager.Instance.play(sounds.buttonClick);
        gameObject.SetActive(false);
        levelSelector.SetActive(true);
    }
}

