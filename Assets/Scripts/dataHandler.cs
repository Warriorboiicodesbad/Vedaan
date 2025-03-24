using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataHandler : MonoBehaviour
{
    public PlayerData playerInfo;
    private int height, weight, age;
    public ToggleGroup tg;
    private string gender;
    public TMPro.TMP_InputField height1, weight1, age1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        if (playerInfo.height > 0 && playerInfo.height < 250)
        {
            playerInfo.height = height;
        }
        
        
        playerInfo.age = age;
        playerInfo.weight = weight;
        if (gender== "Male")
        {
            playerInfo.gender = false;
        }
        else
        {
            playerInfo.gender = true;
        }
    }
}
