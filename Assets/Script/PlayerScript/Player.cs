using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=8f;
    public float _jumpSpeed;
    private Rigidbody2D rigidBody;

    public LayerMask ground;
    private Collider2D playerCollider;
    private Animator animator;
    void Start()
    {
         rigidBody=GetComponent<Rigidbody2D>();
         playerCollider=GetComponent<Collider2D>();
         animator=GetComponent<Animator>();   
    }

    
    void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement(){
        float horizontal=Input.GetAxis("Horizontal");
       
           if(Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.A))
                animator.SetBool("Run",true);

            if(Input.GetKeyUp(KeyCode.D)||Input.GetKeyUp(KeyCode.A))
                animator.SetBool("Run",false);

            transform.Translate(horizontal*speed*speed*Time.deltaTime,0f,0f);

            bool grounded=Physics2D.IsTouchingLayers(playerCollider,ground);

            if(Input.GetKeyDown(KeyCode.Space)){
               if(grounded)
                    rigidBody.velocity=new Vector2(rigidBody.velocity.x,_jumpSpeed);
            }

            animator.SetBool("Jump",grounded);

    }
}
