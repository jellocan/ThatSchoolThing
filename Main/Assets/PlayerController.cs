using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	//Movement Variables
	public float speedForce = 50;
	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		
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
		else if (Input.GetKey(KeyCode.W))
		{
			rb.velocity = new Vector2(rb.velocity.x, 1);
			transform.localScale = new Vector3(-1, 1, 1);
		}
		else
			rb.velocity = new Vector2(0, rb.velocity.y);
	}
}﻿