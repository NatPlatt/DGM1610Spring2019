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
	public float JumpForce;
    public float Health;
    public Sprite mySprite;
    public float oldPos;
	
     
    public void Start()
    {
        Controller = GetComponent<CharacterController>();
        oldPos = transform.position.x;
	    
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
	    
	    
	    if (Input.GetKeyDown(KeyCode.Space))
        		{
        			position.y = JumpForce;
        		}

	    if (transform.position.x > 0)
	    {
		    position.x = global::UnityEngine.Input.GetAxis("Horizontal") * Speed * global::UnityEngine.Time.deltaTime;
			this.GetComponent<SpriteRenderer>().sprite = mySprite;
	    }
	    position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
	    
	    if (oldPos < transform.position.x)
	    {
		    print("moving right");
	    }

	    if (oldPos > transform.position.x)
	    {
		    print("moving left");
	    }

	    oldPos = transform.position.x;
        
		position.y += Gravity * Time.deltaTime;
        
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
