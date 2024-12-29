using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject levelMenuUI;

    void OnTriggerEnter()
    {
        levelMenuUI.SetActive(true);
    }
}
