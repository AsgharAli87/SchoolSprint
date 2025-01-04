using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusSound : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource BusengineSound; // AudioSource ko public banayein taake Inspector mein drag ho sake

    void Awake()
    {
        if (BusengineSound != null)
        {
            BusengineSound.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource not assigned!");
        }
    }
}
