using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Color PowerUpColor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = PowerUpColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
