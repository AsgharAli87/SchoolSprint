using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckSound : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource TruckengineSound; // AudioSource ko public banayein taake Inspector mein drag ho sake

    void Awake()
    {
        // Scene ke awake hone par sound play karein
        if (TruckengineSound != null)
        {
            TruckengineSound.Play(); // Play audio when the scene wakes up
        }
        else
        {
            Debug.LogWarning("AudioSource not assigned!");
        }
    }
}
