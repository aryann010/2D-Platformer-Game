using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerController : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        float Speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(Speed));

        Vector3 scale = transform.localScale;
        if (Speed < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else if(Speed>0) 
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

        bool crouch = Input.GetKey(KeyCode.LeftControl);
        
        if(crouch==true)
        {
            animator.SetBool("crouch", crouch);
        }
        else
        {
            crouch = false;
           animator.SetBool("crouch", crouch);
        }

        float vertical = Input.GetAxisRaw("Vertical");

        if(vertical>0)
        {
            animator.SetBool("jump", true);
        }
        else 
        {
            
            animator.SetBool("jump", false);
        }
    }
}
