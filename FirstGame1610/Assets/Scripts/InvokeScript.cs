using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//learned using Unity tutorials

public class InvokeScript : MonoBehaviour
{
    public GameObject target;
    public int CapsuleAmount = 10;
    public int amountSpawned = 0;

    void Start()
    {
        while (amountSpawned < CapsuleAmount)
        {
            Invoke("SpawnObject", 2);
            amountSpawned++;
        }

        //CancelInvoke("SpawnObject");
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
    }
}
