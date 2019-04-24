using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateBar : MonoBehaviour
{
    private Image barImage;

    public FloatData fillNumber;
    
    void Start()
    {
        barImage = GetComponent<Image>();
    }

    void Update()
    {
        barImage.fillAmount = fillNumber.Value;
    }
}
