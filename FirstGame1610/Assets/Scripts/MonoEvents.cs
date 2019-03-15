using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent, TriggerEvent;

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

    private void OnTriggerEnter(Collider other)
    {
        TriggerEvent.Invoke();
    }
}

