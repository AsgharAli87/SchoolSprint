using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject levelMenuUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            levelMenuUI.SetActive(true);
        }
    }
}
