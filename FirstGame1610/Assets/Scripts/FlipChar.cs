using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipChar : MonoBehaviour
{
    public Transform player;
    private void OnTriggerEnter(Collider other)
    {
        player.Rotate(0, 180, 0);
        print("I am colliding");
    }
}
