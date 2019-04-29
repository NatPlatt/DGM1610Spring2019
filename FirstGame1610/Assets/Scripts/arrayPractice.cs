using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//learned using Unity tutorials

public class arrayPractice : MonoBehaviour
{
    string [] animals = new string[]{"Cockroach", "Pigeon","Mouse"};
    private GameObject[] cockroach = GameObject.FindGameObjectsWithTag("Cockroach");
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
