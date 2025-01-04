using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesCarSound : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource VestSound; // AudioSource ko public banayein taake Inspector mein drag ho sake

    void Awake()
    {
        if (VestSound != null)
        {
            VestSound.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource not assigned!");
        }
    }
}
