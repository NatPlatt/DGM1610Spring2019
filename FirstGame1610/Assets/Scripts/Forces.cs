using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour
{
    private Rigidbody _rBody;
    public Vector3 ForceAmount;

    private void Start()
    {
        _rBody = GetComponent<Rigidbody>();
    }

    public void ApplyForce()
    {
        _rBody.AddForce(ForceAmount);
    }
}
