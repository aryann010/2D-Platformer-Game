using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyController : MonoBehaviour
{
    public Animator animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<playerController>() != null)
        {
            playerController playerController = collision.gameObject.GetComponent<playerController>();
            playerController.pickKey();
            Destroy(gameObject);
        }
    }
}
