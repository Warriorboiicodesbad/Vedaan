using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewItem", menuName = "Game/Item", order = 1)]
public class ItemData : ScriptableObject
{
    public Sprite Image;
    public int calories;
    public float totalFat;
    public float cholesterol;
    public float sodium;
    public float potassium;
    public int carbohydrates;
    public int protien;
    public float iron;  
    public float calcium;
    public float vitaminA;
    public float vitaminB;
    //public float saturatedFat;
    //public float polySaturatedFat;
    //public float dietaryFiber;
    //public float monounSaturatedFat;
    //public float sugars;
    //public float transFat;
}
