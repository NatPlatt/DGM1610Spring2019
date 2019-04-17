using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnims : MonoBehaviour
{
    private Animator anims;
    public float Speed;

    private void Start()
    {
        anims = GetComponent<Animator>();
    }

    void Update()
    {
        anims.SetFloat("Speed",Speed);
    }
}
