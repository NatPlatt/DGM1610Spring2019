using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public SpriteRenderer sprite;
    public Transform groundCheck;
    public LayerMask groundLayer;
    protected float groundCheckRadius;
    protected bool groundCollision;
    public CharacterController Controller;
    protected Vector3 position;
    public float Gravity;
    public float Speed;
    public float Health;
    public void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    
    public void Update()
    {
	    var rigidBody = GetComponent<global::UnityEngine.Rigidbody>();
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
    }
}
