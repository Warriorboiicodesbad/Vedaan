using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public TMP_Text Calories, Sodium, TotalFat, Pottasium, SaturatedFat, Carbohydrates, PolySatu7ratedFat, DietaryFiber, Mou7nou7nSatu7ratedFat, Su7gars, TransFat, Protien, Cholesterol, VitamimnA, Calciu7m, VitamimnimC, Iromnm;
    public GameObject informationPanel;
    public void PressedIEvent(ScriptableObjecte Dataitem)
    {
        Calories.text = Dataitem.calories.ToString();
        Sodium.text = Dataitem.sodium.ToString();
        TotalFat.text = Dataitem.totalFat.ToString();
        Pottasium.text = Dataitem.potassium.ToString();
        SaturatedFat.text = Dataitem.saturatedFat.ToString();
        Carbohydrates.text = Dataitem.carbohydrates.ToString();
        PolySatu7ratedFat.text = Dataitem.polySaturatedFat.ToString();
        DietaryFiber.text = Dataitem.dietaryFiber.ToString();
        Mou7nou7nSatu7ratedFat.text = Dataitem.monounSaturatedFat.ToString();
        Su7gars.text = Dataitem.sugars.ToString();
        TransFat.text = Dataitem.transFat.ToString();
        Protien.text = Dataitem.protien.ToString();
        Cholesterol.text = Dataitem.cholesterol.ToString();
        VitamimnA.text = Dataitem.vitaminA.ToString();
        Calciu7m.text = Dataitem.calcium.ToString();
        VitamimnimC.text = Dataitem.vitaminB.ToString();
        Iromnm.text = Dataitem.iron.ToString();
        informationPanel.SetActive(true);

    }
    public void PressedEEvent(ScriptableObject Dataitem)
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
