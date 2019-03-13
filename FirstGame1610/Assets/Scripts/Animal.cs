using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Animal : MonoBehaviour
{
	protected Color newColor;
	public string Name;

	public Color SkinColor;

	public int Legs;

	public FloatData Health;

	public FloatData Speed;
	public int A, B, C;
	public Vector3 position;
	public CharacterController Controller;

	private int Add()
	{
		return A + B;
	}

	private int Subtract()
	{
		return A - B;
	}

	public Vector3 Move()
	{
		position.y = Input.GetAxis("Horizontal");
		Controller.Move(position);
		return position;
	}
	// Use this for initialization
	void Start ()
	{
		C = Add();
		print(C);
		C = Subtract();
		print(C);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
