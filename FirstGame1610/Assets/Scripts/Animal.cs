using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Animal : MonoBehaviour
{
	protected Color newColor;
	
	public string Name;

	public int Legs;

	public FloatData Health;

	public FloatData Speed;
	
	public int A, B, C;

	public Vector3 position;

	private int Add()
	{
		return A + B;
	}

	private int Subtract()
	{
		return A - B;
	}

	void Start()
	{
		C = Add();
		print(C);
		C = Subtract();
		print(C);
	}

}
