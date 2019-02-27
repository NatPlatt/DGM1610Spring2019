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
	public float Speed;

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
		position.y = Input.GetAxis("Vertical")*Speed*Time.deltaTime;
		position.y -= 1; //added for gravity
		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		Controller.Move(position);
	}
}

