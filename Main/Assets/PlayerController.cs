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
	//animation stuff
	Animator anime;
	Rigidbody2D rb;

    bool canShoot;
    public GameObject projectile;
    public Transform gun;
    public float velocity;
    public float time = 1;
    float timer;
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		anime = GetComponent<Animator> ();
	}

	void Update ()
	{
        touchingfloor = Physics2D.OverlapCircle(groundr.transform.position, radii, ground);
        if (canShoot == false)
        {
            timer = Time.deltaTime;

        }
        if (timer < 0)
        {
            canShoot = true;
            timer = time;
        }
                
        if (Input.GetKey(KeyCode.E)&&canShoot)
        {
           GameObject bullet = (GameObject) Instantiate(projectile, gun.position, Quaternion.identity);
           bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity*gameObject.transform.localScale.x, 0);
            canShoot = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speedForce, rb.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
			anime.SetInteger("animp",1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speedForce, rb.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
			anime.SetInteger("animp",1);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
			anime.SetInteger("animp",0);

        }

        if (Input.GetKey(KeyCode.W)&& touchingfloor== true)
        {
            anime.SetInteger("animp", 2);
            rb.AddForce(jumpV, ForceMode2D.Force);
        }
        
	}
}﻿