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
   
//bool with an if statement to call an event
    void Update()
    {
       
        
    }

   void Start()
   {
       Instantiate(lightBulb, new Vector3(12, 12, 10), Quaternion.identity);
   }
}
