using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dataHandler : MonoBehaviour
{
    public PlayerData playerInfo;
    public ItemData humanIntakeMax;
    private int height, weight, age;
    public ToggleGroup tg;
    private string gender;
    public TMPro.TMP_InputField height1, weight1, age1;
    public TMPro.TMP_Text errorTxt;


    void Update()
    {
        checkToggle();
    }
    public void inputHeight(string Height)
    {
        height = int.Parse(Height);
    }
    public void inputWeight(string Weight)
    {
        weight = int.Parse(Weight);
    }
    public void inputage(string Age)
    {
        age = int.Parse(Age);
    }
    public void checkToggle()
    {
        Toggle something = tg.GetFirstActiveToggle();
        gender = something.name;
    }
    public void submitInfo()
    {
        if (height < 0) errorTxt.text = "Height can't be negative";
        if (weight < 0) errorTxt.text = "Weight can't be negative";
        if (age < 0) errorTxt.text = "Age can't be negative.";
        if (age > 122) errorTxt.text = "Age can't be more than 122";

        if (errorTxt.text != "") return;

        playerInfo.height = height;
        playerInfo.age = age;
        playerInfo.weight = weight;
        if (gender == "Male")
        {
            playerInfo.gender = false;
            playerInfo.bmr = (10 * weight) + (6.25f * height) - (5 * age) + 5;
        }
        else
        {
            playerInfo.gender = true;
            playerInfo.bmr = (10 * weight) + (6.25f * height) - (5 * age) - 161;
        }

        humanIntakeMax.calories = (int)playerInfo.bmr;
        humanIntakeMax.totalFat = humanIntakeMax.calories * 0.3f;
        //humanIntakeMax.transFat = humanIntakeMax.calories * 0.05f;
        //humanIntakeMax.saturatedFat = humanIntakeMax.calories * 0.07f;
        //humanIntakeMax.polySaturatedFat = humanIntakeMax.calories * 0.27f;
        humanIntakeMax.protien = (int)(Random.Range(1.2f, 1.7f) * weight);
        humanIntakeMax.carbohydrates = (int)(humanIntakeMax.calories * Random.Range(0.45f, 0.65f));

        SceneManager.LoadScene("GameScene");
    }
}
