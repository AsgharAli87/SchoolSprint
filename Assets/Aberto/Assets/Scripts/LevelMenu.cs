using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void OpenLevel(int level01)
    {
        string levelName = "Level01" + level01;
        SceneManager.LoadScene("Introduction");
        Debug.Log(levelName);
    }

}

