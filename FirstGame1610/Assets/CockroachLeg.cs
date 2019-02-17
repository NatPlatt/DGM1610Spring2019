using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachLeg : MonoBehaviour
{
    public Color legColor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = legColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
