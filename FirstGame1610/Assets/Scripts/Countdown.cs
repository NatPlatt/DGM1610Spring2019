using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeLeft = 5.0f;

    public Text startingText;
  
    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startingText.text = (timeLeft).ToString("0");
    }
}
