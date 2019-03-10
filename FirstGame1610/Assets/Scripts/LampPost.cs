using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampPost : MonoBehaviour
{
    public bool LightSwitch;
    private Sprite lampFlame;
    private SpriteRenderer sr;
    public GameObject flamePrefab;
    public Transform lightBulb;
    public Color bulbColor;
   
//bool with an if statement to call an event
    void Update()
    {
       
        
    }

   void Start()
   {
       Instantiate(lightBulb, new Vector3(12, 12, 10), Quaternion.identity);
       GetComponent<SpriteRenderer>().color = bulbColor;
       //ask how to change color of instantiated object. added color to prefab, but didn't apply to instantiated bulb
   }

   void Awake()
   {
       int myVar = Convert.ToInt32(AddTwo(9, 2));
       Debug.Log(myVar);
   }

   string AddTwo(int var1, int var2)
   {
       string returnValue = (var1 + var2).ToString();
       return returnValue;
       print(returnValue);
   }
}
