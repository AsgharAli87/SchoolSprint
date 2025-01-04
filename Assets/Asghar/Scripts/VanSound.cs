using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanSound : MonoBehaviour
{
    // Start is called before the first frame update
  public AudioSource MiniVanSound; // AudioSource ko public banayein taake Inspector mein drag ho sake

    void Awake()
    {
        if (MiniVanSound != null)
        {
            MiniVanSound.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource not assigned!");
        }
    }
}
