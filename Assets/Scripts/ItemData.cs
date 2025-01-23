using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewItem", menuName = "Game/Item", order = 1)]
public class ItemData : ScriptableObject
{
    public int calories;
    public float sodium;
    public float totalFat;
    public float potassium;
    public float saturatedFat;
    public int carbohydrates;
    public float polySaturatedFat;
    public float dietaryFiber;
    public float monounSaturatedFat;
    public float sugars;
    public float transFat;
    public int protien;
    public float cholesterol;
    public float vitaminA;
    public float calcium;
    public float vitaminB;
    public float iron;  

    public void ResetValues()
    {
        calories = 0;
        sodium = 0;
        totalFat = 0;
        potassium = 0;
        saturatedFat = 0;
        carbohydrates = 0;
        polySaturatedFat = 0;
        dietaryFiber = 0;
        monounSaturatedFat = 0;
        sugars = 0;
        transFat = 0;
        protien = 0;
        cholesterol = 0;
        vitaminA = 0;
        calcium = 0;
        vitaminB = 0;
        iron = 0;
    }
}
