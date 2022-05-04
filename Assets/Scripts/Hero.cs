﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Hero : MonoBehaviour
{
    //общее
    private Vector3 targetVelocity; // новый вектор что бы присваивать его в rb.velocity
    //------------------------

    //references
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    //-----------------------------

    //Move
    [Header("Move")]
    [SerializeField] private float movementSpeed;
    private float horizontalMove;
    //-----------------------


    //Jump
    [Header("Jump")]
    [SerializeField] private float jumpForce; 
    private  bool isGrounded;
    [SerializeField] private LayerMask groundLayer;
    [Tooltip("Как делаеко идет луч который проверяет землю под ногами  ")]
    [SerializeField] float JumpRayDist = 0.5f; // на сколько далеко идет луч который отвечает за прикосновение 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
            Jump();

    }

   
    void FixedUpdate()
    {
        targetVelocity.x = horizontalMove * Time.fixedDeltaTime*movementSpeed;
        targetVelocity.y = rb.velocity.y;
        rb.velocity = targetVelocity;
    }

    void Move()
    {
        horizontalMove = 0;

        horizontalMove = Input.GetAxis("Horizontal");
        //анимация 
        Flip();

    }

    void Flip()
    {
        if (horizontalMove < 0)
            this.transform.rotation = new Quaternion(0f, 180, 0f, 0);
        if (horizontalMove > 0)
            this.transform.rotation = new Quaternion(0f, 0f, 0f, 0);

    }

    void Jump(float multiply=1)
    {

        CheckIsGrounded();

        //проверка 

        if(isGrounded)
        rb.AddForce(Vector2.up *jumpForce*multiply,ForceMode2D.Impulse);

        //anim
    }

    void CheckIsGrounded()
    {
        isGrounded = false;
        Debug.DrawRay(this.transform.position,Vector2.down* JumpRayDist, Color.blue, 0.3f);
        isGrounded = Physics2D.Raycast(this.transform.position, Vector2.down, JumpRayDist, groundLayer);

    }

   

}
