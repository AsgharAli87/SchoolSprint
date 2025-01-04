using UnityEngine;
using UnityEngine.UI;

public class HealthStop : MonoBehaviour
{
    [SerializeField] private Slider healthSlider; // Drag your health slider here
    [SerializeField] private ThirdPersonMovementScript playerMovement;

    void Update()
    {
        // Check if the slider's value is zero
        if (healthSlider.value <= 0)
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
