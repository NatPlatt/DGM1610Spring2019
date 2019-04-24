using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Mammal
{

	public Color FurColor;
	
	void Start () {
		
		GetComponent<SpriteRenderer>().color = FurColor;
	}
	
}
