using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public SpriteRenderer sprite;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Vector3 groundCheckRadius;
    protected bool groundCollision;
    public CharacterController Controller;
    protected Vector3 position;
    private bool doubleJumped;
    public float Gravity;
    public float Speed;
    public float Health;
    
   
     
    public void Start()
    {
        Controller = GetComponent<CharacterController>();
        
    }


    private void FixedUpdate()
    {
	    if (transform.position.y <= 0.1f)
			{
        		groundCollision = true;
        	    Debug.Log("I'm on the ground." + groundCollision);
            }
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
                
                if (groundCollision)
                {
	                doubleJumped = false;
                }
                

//                if (Input.GetKeyDown("space") && groundCollision)
//                {
//	                rigidBody.velocity = new Vector3(rigidBody.velocity.x, 10);
//                }
                
    }

   
}
