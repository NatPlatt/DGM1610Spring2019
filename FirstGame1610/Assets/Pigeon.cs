using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigeon : Animal
{

	public Color FeatherColor;
	public int Wings;

	public SpriteRenderer sprite;
	public Transform groundCheck;
	
	
	void Start () {
		print("I am a pigeon");
	}
	
	// Update is called once per frame
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
	}
}
