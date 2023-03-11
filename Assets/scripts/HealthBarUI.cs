using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : CastleHealth
{
    
    
    public Slider slider;


   

    public void SetMaxHealth()
    {
        slider.maxValue = defaultHC;
        slider.value = HealthCount;
    }

    public void SetHealth()
    {
        slider.value = HealthCount;
    }
}
