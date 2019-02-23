using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pigeon : Animal
{

	public Color FeatherColor;
	public int Wings;

	public SpriteRenderer sprite;
	public Transform groundCheck;
	public LayerMask groundLayer;
	private float groundCheckRadius;
	private bool groundCollision;
	
	void Start () {
		
	}

	private void FixedUpdate()
	{
		//groundCollision = Physics2D.OverlapBox(groundCheck.position, groundCheckRadius, groundLayer);
	}


	void Update ()
	{
		var rigidBody = GetComponent<Rigidbody2D>();
		var transform = GetComponent<Transform>();

		if (Input.GetKey("right"))
		{
			sprite.flipX = false;
		}

		if (Input.GetKey("left"))
		{
			sprite.flipX = true;
		}

		if (Input.GetKeyDown("space") && groundCollision)
		{
			rigidBody.velocity = new Vector2(rigidBody.velocity.x,10);
		}
	}
}
