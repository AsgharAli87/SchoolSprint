using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public Hpbar _healthbar;
    public GameObject myobject;
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
        GameManager.gamemanager._playerHealth.Healunit(20);
        _healthbar.SetHealth(GameManager.gamemanager._playerHealth.Health);
        Destroy(gameObject);
    }

}

