using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBulb : MonoBehaviour
{
    public Color bulbColor;
    
    void Start()
    {
        GetComponent<SpriteRenderer>().color = bulbColor;
    }

}
