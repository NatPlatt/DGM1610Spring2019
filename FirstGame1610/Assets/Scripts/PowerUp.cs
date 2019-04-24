using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Color PowerUpColor;

    void Start()
    {
        GetComponent<SpriteRenderer>().color = PowerUpColor;
    }

}
