using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gamemanager { get; private set; }
    public UnitHealth _playerHealth = new UnitHealth(100, 100);


    
    void Awake()
    {
        if (gamemanager != null && gamemanager != this)
        {
            Destroy(this);
        }
        else
        {
            gamemanager = this;

        }
        
    }
}