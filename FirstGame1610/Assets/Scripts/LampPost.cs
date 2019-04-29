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
    public Light myLight;
   

   void Start()
   {
       //Instantiate(lightBulb, new Vector3(12, 12, 10), Quaternion.identity);
       GetComponent<SpriteRenderer>().color = bulbColor;
       
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
   }

   void myFunction()
   {
       myLight.enabled = !myLight.enabled;
   }
}
