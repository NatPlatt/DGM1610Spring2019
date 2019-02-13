using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Mammal
{

	public Color FurColor;
	
	// Use this for initialization
	void Start () {
		print("Let's see if this causes an error again");
		print("I am a mouse");
		GetComponent<SpriteRenderer>().color = FurColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
