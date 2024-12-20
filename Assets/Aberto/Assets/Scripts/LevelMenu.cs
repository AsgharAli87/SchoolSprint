using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void OpenLevel(int levelId)
    {
        string levelName = "Level0" + levelId;
        SceneManager.LoadScene(levelName);
        Debug.Log(levelName);
    }
}

