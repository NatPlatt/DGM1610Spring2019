using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockroach : Animal {

	// Use this for initialization
	void Start () {
		print("I am a cockroach");
		GetComponent<SpriteRenderer>().color = SkinColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
