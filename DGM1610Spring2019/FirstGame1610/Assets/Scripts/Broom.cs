using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Broom : MonoBehaviour
{
    public UnityEvent Event;
    public UnityEvent OnGrounded, OffGrounded;
    private CharacterController Controller;
    private Vector3 position;
    public float Speed;
    public float Gravity;
    public float jumpForce;

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
        else
        {
            OffGrounded.Invoke();
        }

        if (Controller.isGrounded && Input.GetButton("Jump"))
        {
            position.y = jumpForce * Time.deltaTime;
        }
     
        position.y += Gravity * Time.deltaTime;
        
        
        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		
		
        Controller.Move(position);
    }
}
