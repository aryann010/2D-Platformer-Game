using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingGround : MonoBehaviour
{
    public Rigidbody2D rb2d;

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {
            StartCoroutine("fallDown");

        }

    }
    IEnumerator fallDown()
    {
        yield return new WaitForSeconds(0.75f);
        rb2d.isKinematic = false;
    }

}
