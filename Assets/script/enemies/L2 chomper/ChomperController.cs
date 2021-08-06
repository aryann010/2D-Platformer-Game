using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChomperController : MonoBehaviour
{
    public Animator animator;
    bool MoveRight = true;
    float MoveSpeed = 2f;



    private void OnCollisionEnter2D(Collision2D collision)

    {
        if(collision.gameObject.GetComponent<playerController>() != null)
        {
            playerController PlayerController = collision.gameObject.GetComponent<playerController>();
            PlayerController.TakeDamage(33.4f);

        }

    }

    private void Update()
    {




        if (transform.position.x < 0f)
        {
            MoveRight = true;
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }

        if (transform.position.x > 6.42f)
        {
            MoveRight = false;
            transform.localScale = new Vector2(-1f * Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }

        if (MoveRight)

            transform.position = new Vector2(transform.position.x + MoveSpeed * Time.deltaTime, transform.position.y);

        else

            transform.position = new Vector2(transform.position.x - MoveSpeed * Time.deltaTime, transform.position.y);
    }
}
