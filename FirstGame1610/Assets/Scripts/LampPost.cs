using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampPost : MonoBehaviour
{
    public bool LightSwitch;
    private Sprite lampFlame;
    private SpriteRenderer sr;
    public GameObject flamePrefab;
   
    void Update()
    {
        if (LampPost)
        {
            GameObject go = Instantiate(Resources.Load("flamePrefab"")) as GameObject;
        }
        
    }

    private void Start()
    {
        lampFlame = Sprite.Create();
    }
}
