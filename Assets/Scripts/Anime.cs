using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Anime : MonoBehaviour
{
    public new Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animation.SetBool("iswalking", true);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animation.SetBool("iswalking", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animation.SetBool("isrun", true);

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animation.SetBool("isrun", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animation.SetBool("isback", true);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animation.SetBool("isback", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animation.SetBool("left", true);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animation.SetBool("left", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animation.SetBool("right", true);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animation.SetBool("right", false);
        }
    }
}
