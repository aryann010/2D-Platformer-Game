using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class timeline : MonoBehaviour
{

    private void Update()
    {
        bool c = Input.GetKey(KeyCode.Space);
        nextScene(c);


    }
    private void nextScene(bool c)
    {
        if (c)
        {
            SceneManager.LoadScene(6);
        }
    }

}