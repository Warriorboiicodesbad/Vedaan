using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    public string gameSceneName;

    // Start is called before the first frame update
    public void PlayButtonAction()
    {
        SceneManager.LoadScene(gameSceneName);
    }
    public void ExitButtonAction()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
