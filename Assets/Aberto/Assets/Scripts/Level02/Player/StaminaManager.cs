using UnityEngine;
using UnityEngine.UI;

public class StaminaManager : MonoBehaviour
{
    [SerializeField] private Slider staminaSlider; // Drag your health slider here
    [SerializeField] private ThirdPersonMovementScript playerMovement;

    void Update()
    {
        // Check if the slider's value is zero
        if (staminaSlider.value <= 0)
        {
            playerMovement.walkspeed = 5f;
            // FreezeGame();
        }
    }
    private void Start()
    {
        Time.timeScale = 1f;
    }

    /* private void FreezeGame()
     {
         Debug.Log("Health is zero! Game is now frozen.");
         Time.timeScale = 0; // Freeze the game
     }
    */
}
