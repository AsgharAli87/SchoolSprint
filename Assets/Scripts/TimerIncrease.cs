using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerIncrease : MonoBehaviour
{
    public Timer _timer;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _timer.remainingTime += 10;
             Destroy(transform.parent.gameObject);
        }

        
    }
}
