using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockroach : Insect
{
	public Color SkinColor;
	public Color DangerColor;
	public bool Danger;

	
	void Start () {
		
		//GetComponent<SpriteRenderer>().color = SkinColor;
		
		
	}
	
	
	void Update () 
	{
		if (Danger == true)
		{
			GetComponent<SpriteRenderer>().color = DangerColor;
			Debug.Log("I am in danger");
		}
		else
		{
			GetComponent<SpriteRenderer>().color = SkinColor;
			Debug.Log("I am fine");
		}
	}
}
