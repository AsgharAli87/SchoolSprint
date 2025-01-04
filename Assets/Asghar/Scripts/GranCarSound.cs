using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranCarSound : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource CarengineSound; // AudioSource ko public banayein taake Inspector mein drag ho sake

    void Awake()
    {
        
        if (CarengineSound != null)
        {
            CarengineSound.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource not assigned!");
        }
    }
}
