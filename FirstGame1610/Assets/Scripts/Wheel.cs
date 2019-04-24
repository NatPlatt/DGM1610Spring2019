using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
 
    void Update()
    {
        transform.Rotate(Vector3.forward * -5);
    }
}
