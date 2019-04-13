using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    public int intelligence = 5;

    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Hello there!");
                break;
            case 4:
                print("How dare you?!");
                break;
            case 3:
                print("I forgot my pearls!");
                break;
            case 2: 
                print("Run away!");
                break;
            case 1:
                print("Let's go!");
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
}
