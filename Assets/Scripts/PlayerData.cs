using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public ScriptableObjecte humanIntake;
    public ScriptableObjecte humanIntakeMax;
    public TMP_Text Calories, Sodium, TotalFat, Pottasium, SaturatedFat, Carbohydrates, PolySatu7ratedFat, DietaryFiber, Mou7nou7nSatu7ratedFat, Su7gars, TransFat, Protien, Cholesterol, VitamimnA, Calciu7m, VitamimnimC, Iromnm, itemName;
    public GameObject informationPanel;
    public void PressedIEvent(ScriptableObjecte Dataitem)
    {
        itemName.text = Dataitem.name;
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
    public void PressedEEvent(ScriptableObjecte Dataitem)
    {
        humanIntake.calories += Dataitem.calories;
        humanIntake.sodium += Dataitem.sodium;
        humanIntake.totalFat += Dataitem.totalFat;
        humanIntake.potassium += Dataitem.potassium;
        humanIntake.saturatedFat += Dataitem.saturatedFat;
        humanIntake.carbohydrates += Dataitem.carbohydrates;
        humanIntake.polySaturatedFat += Dataitem.polySaturatedFat;
        humanIntake.dietaryFiber += Dataitem.dietaryFiber;
        humanIntake.monounSaturatedFat += Dataitem.monounSaturatedFat;
        humanIntake.sugars += Dataitem.sugars;
        humanIntake.transFat += Dataitem.transFat;
        humanIntake.protien += Dataitem.protien;
        humanIntake.cholesterol += Dataitem.cholesterol;
        humanIntake.vitaminA += Dataitem.vitaminA;
        humanIntake.calcium += Dataitem.calcium;
        humanIntake.vitaminB += Dataitem.vitaminB;
        humanIntake.iron += Dataitem.iron;
        if (humanIntake.calories >= humanIntakeMax.calories)
        {

        }
        if (humanIntake.sodium >= humanIntakeMax.sodium)
        {

        }
        if (humanIntake.totalFat >= humanIntakeMax.totalFat)
        {

        }
        if (humanIntake.potassium >= humanIntakeMax.potassium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {


        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   
}
