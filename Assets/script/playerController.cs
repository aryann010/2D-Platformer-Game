using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playerController : MonoBehaviour
{
    public Animator animator;
    public scoreController scoreController;
    public float speed;
    public float jump;
    public float jumpLength;
    public LayerMask groundLayer;
    public bool onGround = false;
    private Rigidbody2D rb2d;
    public float health;
    public float maxHealth=100f;
    public healthBarController healthBar;
    


    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        onGround = Physics2D.Raycast(transform.position, Vector2.down, jumpLength, groundLayer);
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        playMovementAnimation(horizontal);
       
        bool crouch = Input.GetKey(KeyCode.LeftControl);
        crouchAnimation(crouch);

        float vertical = Input.GetAxisRaw("Vertical");
        jumpAnimation(vertical);
        moveCharacter(horizontal);
       
        

    }

   
    public void pickKey()
    {
        scoreController.increaseScore(10);
    }

    private void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        characterJump(vertical);
    }
    private void jumpAnimation(float vertical)
    {
       animator.SetBool("jump", vertical>0);  
    }

    private void crouchAnimation(bool crouch)
    {
      animator.SetBool("crouch", crouch); 
    }

    private void playMovementAnimation(float horizontal)
    {
        
        {
            animator.SetFloat("speed", Mathf.Abs(horizontal));
            Vector3 scale = transform.localScale;
            scale.x = (horizontal < 0 ? -1f : (horizontal > 0 ? 1f : (scale.x / Mathf.Abs(scale.x)))) * Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        
    }

    private void moveCharacter(float horizontal)
    {


        Vector3 position = transform.position;
        position.x += horizontal * speed * Time.deltaTime; //speed*(1/(30/sec)), 30fps
        transform.position = position;        
    }  
    private void characterJump(float vertical)
    {
        if (vertical > 0 && onGround)
         {
            Vector2 movement = new Vector2(rb2d.velocity.x, jump);
            rb2d.velocity = movement;
            
         }
    }
    public void TakeDamage(float h)
    {

        health -= h;
        healthBar.updateHealthBar();
    }

    
}
