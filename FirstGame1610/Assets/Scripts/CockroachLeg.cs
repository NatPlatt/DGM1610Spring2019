using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachLeg : MonoBehaviour
{
    public Color legColor;
    
    void Start()
    {
        GetComponent<SpriteRenderer>().color = legColor;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
