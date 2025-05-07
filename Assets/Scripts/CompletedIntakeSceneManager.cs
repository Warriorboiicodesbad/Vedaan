using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompletedIntakeSceneManager : MonoBehaviour
{
    [SerializeField] TMP_Text feedbackTxt, allDaysCompletedTxt;
    [SerializeField] GameObject nextButton;
    [SerializeField] PlayerData playerData;


    private void Start()
    {
        feedbackTxt.text = $"Day {GameData.currentLevel} Intake Completed";

        GameData.currentLevel++;
        playerData.day = GameData.currentLevel;
        if (GameData.currentLevel >= GameData.maxLevel)
        {
            allDaysCompletedTxt.gameObject.SetActive(true);
            nextButton.SetActive(false);
        }

    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
