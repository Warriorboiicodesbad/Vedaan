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
}
