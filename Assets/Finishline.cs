using UnityEngine;

public class Finishline : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached the finish line! Game is now frozen.");
            Time.timeScale = 0f; 
        }
    }
}