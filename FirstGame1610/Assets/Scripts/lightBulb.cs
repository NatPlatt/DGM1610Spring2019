using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBulb : MonoBehaviour
{
    public Color bulbColor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = bulbColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
