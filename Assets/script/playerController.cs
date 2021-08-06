using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float jump;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame

   
    void Update()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        playMovementAnimation(horizontal);
       

        bool crouch = Input.GetKey(KeyCode.LeftControl);
        crouchAnimation(crouch);

        float vertical = Input.GetAxisRaw("Vertical");
        jumpAnimation(vertical);
        moveCharacter(horizontal, vertical);


    }

    private void jumpAnimation(float vertical)
    {
        if (vertical > 0)
        {
            animator.SetBool("jump", true);
        }
        else
        {

            animator.SetBool("jump", false);
        }
    }

    private void crouchAnimation(bool crouch)
    {
        if (crouch == true)
        {
            animator.SetBool("crouch", crouch);
        }
        else
        {
            crouch = false;
            animator.SetBool("crouch", crouch);
        }

      
    }

    private void playMovementAnimation(float horizontal)
    {
        animator.SetFloat("speed", Mathf.Abs(horizontal));

        Vector3 scale = transform.localScale;
        if (horizontal < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;
    }

    private void moveCharacter(float horizontal, float vertical)
    {
        Vector3 position = transform.position;
        position.x += horizontal * speed * Time.deltaTime; //speed*(1/(30/sec)), 30fps 
        transform.position = position;
        
        //for vertical
        if(vertical>0 )
        {
            rb2d.AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
            
        }
    }

}
