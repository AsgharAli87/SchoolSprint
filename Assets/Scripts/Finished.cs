using UnityEngine;
using UnityEngine.SceneManagement;

public class Finished: MonoBehaviour
{

    public GameManagerScript gameManager;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 0f;
            gameManager.GameOver();

        }
    }
}