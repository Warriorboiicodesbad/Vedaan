using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class menuManager : MonoBehaviour
{
    // Start is called before the first frame update
  public void changeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void gameExit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
    }
}
