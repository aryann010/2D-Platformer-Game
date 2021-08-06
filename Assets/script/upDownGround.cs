using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDownGround : MonoBehaviour
{
    //public Animator animator;
    bool MoveUp = true;
    float MoveSpeed = 2.5f;

    private void Update()
    {




        if (transform.position.y < 0f)
        {
            MoveUp = true;
           // transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }

        if (transform.position.y > 20.6f)
        {
            MoveUp = false;
           // transform.localScale = new Vector2(-1f * Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }

        if (MoveUp)

            transform.position = new Vector2(transform.position.x,transform.position.y + MoveSpeed * Time.deltaTime);

        else

            transform.position = new Vector2(transform.position.x,transform.position.y - MoveSpeed * Time.deltaTime);
    }
}
