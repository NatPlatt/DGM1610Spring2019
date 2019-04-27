using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color changeColor;
    void Start()
    {
        GetComponent<SpriteRenderer>().color = changeColor;
    }

    
}
