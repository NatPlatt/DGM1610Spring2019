using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponSwitches : MonoBehaviour
{
    public UnityEvent ShootingEvent, LoadingEvent, EmptyEvent;
    public enum States
    {
        Shooting,
        Loading,
        Empty
        
    }

    public States CurrentState;
    
    void Update()
    {
        switch (CurrentState)
        {
            case States.Shooting:
                ShootingEvent.Invoke();
                break;
            case States.Loading:
                LoadingEvent.Invoke();
                break;
            case States.Empty:
                EmptyEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
       
    }
}
