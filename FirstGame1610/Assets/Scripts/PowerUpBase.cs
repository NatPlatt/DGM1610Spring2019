using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Events;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
    public float Value = 20.5f;

    private void OnEnable()
    {
        Value = 10;
    }

    public void OnPowerUp(float addValue)
    {
        Value += addValue;
    }

}
