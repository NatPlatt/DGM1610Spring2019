using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockroach : Insect
{
	public Transform roachLegs;

	// Use this for initialization
	void Start () {
		
		GetComponent<SpriteRenderer>().color = SkinColor;
		
		for (int y = 0; y < 2; y++)
                {
                    for (int x = 0; x < 2; x++)
                    {
                        Instantiate(roachLegs, new Vector3(x, y, 0), Quaternion.identity);
                    }
                }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
