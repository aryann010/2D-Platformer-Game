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
    }
}
