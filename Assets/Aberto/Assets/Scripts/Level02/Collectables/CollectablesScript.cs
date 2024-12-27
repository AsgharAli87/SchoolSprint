using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesScript : MonoBehaviour
{
    [SerializeField] private bool timeCollectable;
    [SerializeField] private float collectableValue = 30f;
    private Timer timer;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(timeCollectable)
            {
                timer.IncreaseTime(collectableValue);
            }
            gameObject.SetActive(false);
        }        
    }
}
