using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveSwitch : MonoBehaviour
{
    public UnityEvent RunningEvent, WalkingEvent, StandingEvent;

    public enum States
    {
        Running,
        Walking,
        Standing
    }

    public States MoveState;
    void Update()
    {
        switch (MoveState)
        {
            case States.Running:
                RunningEvent.Invoke();
                break;
            case States.Walking:
                WalkingEvent.Invoke();
                break;
            case States.Standing:
                StandingEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
