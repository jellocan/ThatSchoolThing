using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	//Movement Variables
	public float speedForce = 5;
    public Vector2 jumpV;
    public bool touchingfloor;
    public Transform groundr;
    public float radii;
    public LayerMask ground;
	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
        touchingfloor = Physics2D.OverlapCircle(groundr.transform.position, radii, ground);
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speedForce, rb.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speedForce, rb.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.W)&& touchingfloor== true)
        {
            rb.AddForce(jumpV, ForceMode2D.Force);
        }
        
	}
}﻿