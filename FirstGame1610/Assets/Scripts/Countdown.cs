using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeLeft = 1.0f;
    public int i = 5;

    public Text startingText;
  
    
    void Update()
    {
        
        timeLeft += Time.deltaTime;
        startingText.text = (timeLeft).ToString("time: 0 secs"); 
            
       
        
    }
}
