using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    private void Awake()
    {
        soundManager.Instance.play(sounds.rain);
    }
}
