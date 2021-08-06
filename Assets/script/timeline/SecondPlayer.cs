using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayer : MonoBehaviour
{
    public GameObject timelineGobj;



    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            timelineGobj.gameObject.SetActive(true);
            

        }

    }
}
