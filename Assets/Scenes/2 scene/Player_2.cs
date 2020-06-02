using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    private Groundcheck groundcheck;
    public int Lives = 3;
    public float speed = 4.0f;
    public float jumpforce = 1.0f;
    public Rigidbody2D PlayerRigidbody;
    public Animator charAnimator;
    public SpriteRenderer sprite;
    bool OnGround;

    private void Awake()
    {
        groundcheck = GetComponentInChildren<Groundcheck>();
        PlayerRigidbody = GetComponentInChildren<Rigidbody2D>();
        charAnimator = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    void Start()
    {

    }

    void Move()
    {
        Vector3 tempvector = Vector3.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + tempvector, speed * Time.deltaTime);
        charAnimator.SetInteger("State", 1);

        if (tempvector.x < 0)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }
    void Jump()
    {
        if (groundcheck.CheckGround())
        {
            PlayerRigidbody.AddForce(transform.up * jumpforce, ForceMode2D.Impulse);
        }
    }

    void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1.3f);
        OnGround = colliders.Length > 1;
        Debug.Log(colliders.Length);
    }

    private void FixedUpdate()
    {
        CheckGround();
    }
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            Move();
        }
        /* if(OnGround && Input.GetButton("Jump"))
         {
             Jump();
             charAnimator.SetInteger("State", 2);
         }
         */

        if (Input.GetButton("Jump"))
        {
            Jump();
            charAnimator.SetInteger("State", 2);
        }
        if (!Input.anyKey)
        {
            charAnimator.SetInteger("State", 0);
        }
    }
}

