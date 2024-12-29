using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;
 
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    
    public void SetMaxStamina(int maxStamina)
    {
        slider.value = maxStamina;
    }


    public void SetStamina(int stamina)
    {
        slider.value = stamina;
    }
}
