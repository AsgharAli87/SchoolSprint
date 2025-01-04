using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Playerbehave : MonoBehaviour
{
    [SerializeField] Hpbar _healthbar;
    [SerializeField] private float damageInterval = 60f; // Time interval between damage in seconds
    private float damageTimer = 0.0f; // Timer to track intervals
    public GameManagerScript gameManager;

    private bool isDead;
   
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            damageTimer += Time.deltaTime; // Increment timer based on frame time
            if (damageTimer >= damageInterval) // Check if the interval has elapsed
            {
                PLayerTakeDmg(1); // Apply damage
                Debug.Log("Player Health: " + GameManager.gamemanager._playerHealth.Health);
                damageTimer = 0.0f; // Reset the timer
            }
        }
        else
        {
            damageTimer = 0.0f; // Reset the timer when 'W' is not pressed
        }

    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.transform.parent.gameObject.CompareTag("IaCar"))
        {
            Time.timeScale = 0f;
            isDead = true;
            gameManager.GameOver();
        }
    }

    private void PLayerTakeDmg(float dmg)
    {
        GameManager.gamemanager._playerHealth.Dmgunit((int)dmg); // Deduct health
        _healthbar.SetHealth(GameManager.gamemanager._playerHealth.Health); // Update health bar
    }
    private void PLayerHealing(int Heal)
    {
        GameManager.gamemanager._playerHealth.Healunit(Heal);
        _healthbar.SetHealth(GameManager.gamemanager._playerHealth.Health);
    }
}
