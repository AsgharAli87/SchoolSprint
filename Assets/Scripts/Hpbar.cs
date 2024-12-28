using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{   
    Slider slider;
 
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    
    public void SetMaxHealth(int maxHealth)
    {
        slider.value = maxHealth;
    }


    public void SetHealth(int Health)
    {
        slider.value = Health;
    }


}
