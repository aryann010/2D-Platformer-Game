using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class chomper2Controller : MonoBehaviour
{
    public Animator animator;
    bool moveRight = true;
    float moveSpeed = 2f;



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
        
        

        
        if (transform.position.x < 16.42f)
        { 
        moveRight = true;
        transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }

        if (transform.position.x > 38.51f)
        {
            moveRight = false;
            transform.localScale = new Vector2(-1f * Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }

        if (moveRight)
         
        transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        
        else
            
        transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
