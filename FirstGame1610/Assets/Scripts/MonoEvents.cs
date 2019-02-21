using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent;

    void Start()
    {
        StartEvent.Invoke();
    }
    void OnEnable()
    {
        EnableEvent.Invoke();
    }
    
    void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }
        
    void Update()
    {
        UpdateEvent.Invoke();
    }
}
