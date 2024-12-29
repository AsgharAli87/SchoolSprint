// using System.Collections;
// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;

// [System.Serializable]
// public class BehaviourOfPlayer : MonoBehaviour
// {
//     [SerializeField] StaminaBar staminaBar;
//     [SerializeField] private float damageInterval = 60f; // Time interval between damage in seconds
//     private float damageTimer = 0.0f; // Timer to track intervals

//     void Start()
//     {
//         staminaBar.SetMaxStamina(GameManagerScript.newgamemanager._playerStamina.MaxHealth);
       
//     }

//     void Update()
//     {
//         if (Input.GetKey(KeyCode.LeftShift))
//         {
//             damageTimer += Time.deltaTime; // Increment timer based on frame time
//             if (damageTimer >= damageInterval) // Check if the interval has elapsed
//             {
//                 PLayerTakeDmg(1); // Apply damage
//                 Debug.Log("Player Health: " + GameManagerScript.newgamemanager._playerStamina.MaxHealth);
//                 damageTimer = 0.0f; // Reset the timer
//             }
//         }
//         else
//         {
//             damageTimer = 0.0f; // Reset the timer when 'W' is not pressed
//         }

//     }
   

//     private void PLayerTakeDmg(float dmg)
//     {
//         GameManagerScript.newgamemanager._playerStamina.Dmgunit((int)dmg); // Deduct health
//         staminaBar.SetStamina(GameManagerScript.newgamemanager._playerStamina.Health); // Update health bar
//     }
//     private void PLayerHealing(int Heal)
//     {
//         GameManagerScript.newgamemanager._playerStamina.Healunit(Heal);
//         staminaBar.SetStamina(GameManagerScript.newgamemanager._playerStamina.Health);
//     }
// }
