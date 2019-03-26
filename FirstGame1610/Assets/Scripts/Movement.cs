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
	    
      // if (Input.GetKeyDown("space"))
      // {
	  //     Vector3 up = transform.TransformDirection(Vector3.up);
	 //      rigidBody.AddForce(up * 5, ForceMode.Impulse);
      // } > 0 || global::UnityEngine.Input.GetAxis("Vertical") < 0
	    
	    if (global::UnityEngine.Input.GetKeyDown(KeyCode.Space))
        		{
			        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
	                //Vector3 up = transform.TransformDirection(Vector3.up)
        			//position.y = rigidBody.AddForce(up * 5, ForceMode.Impulse);
        		}
        		else
        		{
        			position.y = Gravity * global::UnityEngine.Time.deltaTime;
        		}
//
//	    if (Input.GetAxis("Horizontal") > 0)
//	    {
//		    position.x = global::UnityEngine.Input.GetAxis("Horizontal") * Speed * global::UnityEngine.Time.deltaTime;
//		    this.GetComponent<SpriteRenderer>().sprite = mySprite;
//	    }
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
