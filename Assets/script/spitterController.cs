using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spitterController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            playerController PlayerController = collision.gameObject.GetComponent<playerController>();
            PlayerController.TakeDamage(100f);

        }

    }
}
