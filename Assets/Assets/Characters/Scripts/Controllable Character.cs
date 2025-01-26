using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllableCharacter : MonoBehaviour
{   
    bool isFacingRight = false;
    bool isGrounded = true;
    public Rigidbody2D bubble;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        bubble = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Game Over") != null && GameObject.Find("Game Over").activeSelf)
        {
            return;
        }

        FlipSprite();

        if (Input.GetKeyDown(KeyCode.A))
        {
            
            animator.SetTrigger("Pindot");
            bubble.velocity = new Vector2(-5, 2);

        }

         if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Pindot");
            bubble.velocity = new Vector2(5, 2);
            
        }

        FlipSprite();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("PindotJump");
            bubble.velocity = new Vector2(0, 5);
            
        }
    }

    private void FixedUpdate()
    {
        animator.SetFloat("Speed", Mathf.Abs(bubble.velocity.x));
    }

    void FlipSprite()
    {
        if (isFacingRight && bubble.velocity.x < 0f || !isFacingRight && bubble.velocity.x > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
        }
    }
}
