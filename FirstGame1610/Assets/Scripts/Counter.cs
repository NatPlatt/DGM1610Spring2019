using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    public int Value = 3, MinValue = 0;
    public float WaitTime = 1;

    public UnityEvent OnCountEvent, OnEndEvent;

    public void StartCounter()
    {
        StartCoroutine(RunCounter());
    }
    
    private IEnumerator RunCounter() //couroutine
    {
        var waitObject = new WaitForSeconds(WaitTime);
        
        while (Value > MinValue)
        {
            yield return waitObject;
            print(Value);
            Value--;
        }

        yield return waitObject;
        OnEndEvent.Invoke();
    }

}