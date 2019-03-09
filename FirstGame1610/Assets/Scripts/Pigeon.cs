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
	private CharacterController Controller;
	private Vector3 position;
	public float Gravity;
	public float Speed;
	
	
	void Start ()
	{
		Controller = GetComponent<CharacterController>();
	}

	private void FixedUpdate()
	{
		//groundCollision = Physics2D.OverlapBox(groundCheck.position, groundCheckRadius, groundLayer);
	}


	void Update ()
	{
		var rigidBody = GetComponent<global::UnityEngine.Rigidbody2D>();
		var transform = GetComponent<global::UnityEngine.Transform>();
		if (global::UnityEngine.Input.GetAxis("Vertical") > 0 || global::UnityEngine.Input.GetAxis("Vertical") < 0)
		{
			position.y = global::UnityEngine.Input.GetAxis("Vertical") * Speed * global::UnityEngine.Time.deltaTime;
		}
		else
		{
			position.y = Gravity * global::UnityEngine.Time.deltaTime;
		}

		position.x = global::UnityEngine.Input.GetAxis("Horizontal") * Speed * global::UnityEngine.Time.deltaTime;

		Controller.Move(position);
//		if (Input.GetKey("right"))
//		{
//			sprite.flipX = false;
//		}
//
//		if (Input.GetKey("left"))
//		{
//			sprite.flipX = true;
//		}
//
//		if (Input.GetKeyDown("space") && groundCollision)
//		{
//			rigidBody.velocity = new Vector2(rigidBody.velocity.x,10);
//		}
	}
}
