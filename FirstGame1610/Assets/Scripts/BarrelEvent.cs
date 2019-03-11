using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BarrelEvent : MonoBehaviour
{
	public UnityEvent Event;
	public UnityEvent OnGrounded;
	private CharacterController Controller;
	private Vector3 position;
	public float Rate;
	public float Gravity;

	private void Start()
	{
		Controller = GetComponent<CharacterController>();
	}

	private void OnCollisionEnter2D()
	{
		Event.Invoke();
	}

	private void Update()
	{
		if (Controller.isGrounded)
		{
			OnGrounded.Invoke();
		}

		if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
		{
			position.y = Input.GetAxis("Vertical") * Rate * Time.deltaTime;
		}
		else
		{
			position.y = Gravity * Time.deltaTime; 
		}

		position.x = Input.GetAxis("Horizontal") * Rate * Time.deltaTime;
		
		
		Controller.Move(position);
	}
}

