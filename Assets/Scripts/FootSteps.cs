using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public GameObject footstep;
    public GameObject jump;

    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
        jump.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            jumps();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumpsstop();
        }
        if (Input.GetKey("w"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("s"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("a"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("d"))
        {
            footsteps();
        }

        if (Input.GetKeyUp("w"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("s"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("a"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("d"))
        {
            StopFootsteps();
        }

    }

    void footsteps()
    {
        footstep.SetActive(true);
    }
    void jumps()
    {
        jump.SetActive(true);

    }
    void jumpsstop()
    {
        jump.SetActive(false);
    }
    void StopFootsteps()
    {
        footstep.SetActive(false);
    }
   
   
}