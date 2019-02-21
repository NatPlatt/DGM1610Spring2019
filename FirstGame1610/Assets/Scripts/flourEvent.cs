using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class flourEvent : MonoBehaviour
{
	public UnityEvent Event;

	private void OnCollisionEnter2D()
	{
		Event.Invoke();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
