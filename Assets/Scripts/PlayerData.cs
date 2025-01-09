using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public ScriptableObjecte humanIntake;
    public ScriptableObjecte humanIntakeMax;
    public TMP_Text Calories, Sodium, TotalFat, Pottasium, SaturatedFat, Carbohydrates, PolySatu7ratedFat, DietaryFiber, Mou7nou7nSatu7ratedFat, Su7gars, TransFat, Protien, Cholesterol, VitamimnA, Calciu7m, VitamimnimC, Iromnm, itemName;
    public TMP_Text CaloriesConsumed, SodiumConsumed, TotalFatConsumed, PottasiumConsumed, SaturatedFatConsumed, CarbohydratesConsumed, PolySatu7ratedFatConsumed, DietaryFiberConsumed, Mou7nou7nSatu7ratedFatConsumed, Su7garsConsumed, TransFatConsumed, ProtienConsumed, CholesterolConsumed, VitamimnAConsumed, Calciu7mConsumed, VitamimnimCConsumed, IromnmConsumed;
    public GameObject informationPanel;
    public Slider CalorieSlider;
    public Slider SodiumSlider;
    public Slider TotalFatSlider;
    public Slider PottasiumSlider;
    public Slider SaturatedFatSlider;
    public Slider CarbohydratesSlider;
    public Slider PolySaturatedFatSlider;
    public Slider DietaryFiberSlider;
    public Slider MonounSaturatedFatSlider;
    public Slider SugarsSlider;
    public Slider TransFatSlider;
    public Slider ProtienSlider;
    public Slider CholesterolSlider;
    public Slider VitaminASlider;
    public Slider CalciumSlider;
    public Slider VitaminCSlider;
    public Slider IronSlider;
    public GameObject sliderPanel;
    public void onShowPanel(ScriptableObjecte Dataitem)
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
        CalorieSlider.value = (float)humanIntake.calories / humanIntakeMax.calories;
        CaloriesConsumed.text = humanIntake.calories.ToString() + "/" + humanIntakeMax.calories.ToString();

        humanIntake.sodium += Dataitem.sodium;
        SodiumSlider.value = (float)humanIntake.calories / humanIntakeMax.calories;
        SodiumConsumed.text = humanIntake.sodium.ToString() + "/" + humanIntakeMax.sodium.ToString();

        humanIntake.totalFat += Dataitem.totalFat;
        TotalFatSlider.value = (float)humanIntake.totalFat / humanIntakeMax.totalFat;
        TotalFatConsumed.text = humanIntake.totalFat.ToString() + "/" + humanIntakeMax.totalFat.ToString();

        humanIntake.potassium += Dataitem.potassium;
        PottasiumSlider.value = (float)humanIntake.potassium / humanIntakeMax.potassium;
        PottasiumConsumed.text = humanIntake.potassium.ToString() + "/" + humanIntakeMax.potassium.ToString();
        
        humanIntake.saturatedFat += Dataitem.saturatedFat;
        SaturatedFatSlider.value = (float)humanIntake.saturatedFat / humanIntakeMax.saturatedFat;
        SaturatedFat.text = humanIntake.saturatedFat.ToString() + "/" + humanIntakeMax.saturatedFat.ToString();

        humanIntake.carbohydrates += Dataitem.carbohydrates;
        CarbohydratesSlider.value = (float)humanIntake.carbohydrates / humanIntakeMax.carbohydrates;
        CarbohydratesConsumed.text = humanIntake.carbohydrates.ToString() + "/" + humanIntakeMax.carbohydrates.ToString();

        humanIntake.polySaturatedFat += Dataitem.polySaturatedFat;
        PolySaturatedFatSlider.value = (float)humanIntake.polySaturatedFat / humanIntakeMax.polySaturatedFat;
        PolySatu7ratedFatConsumed.text = humanIntake.polySaturatedFat.ToString() + "/" + humanIntakeMax.polySaturatedFat.ToString();

        humanIntake.dietaryFiber += Dataitem.dietaryFiber;
        DietaryFiberSlider.value = (float)humanIntake.dietaryFiber / humanIntakeMax.dietaryFiber;
        DietaryFiberConsumed.text = humanIntake.dietaryFiber.ToString() + "/" + humanIntakeMax.dietaryFiber.ToString();

        humanIntake.monounSaturatedFat += Dataitem.monounSaturatedFat;
        MonounSaturatedFatSlider.value = (float)humanIntake.monounSaturatedFat / humanIntakeMax.monounSaturatedFat;
        Mou7nou7nSatu7ratedFatConsumed.text = humanIntake.monounSaturatedFat.ToString() + "/" + humanIntakeMax.monounSaturatedFat.ToString();
        
        humanIntake.sugars += Dataitem.sugars;
        SugarsSlider.value = (float)humanIntake.sugars / humanIntakeMax.sugars;
        Su7garsConsumed.text = humanIntake.sugars.ToString() + "/" + humanIntakeMax.sugars.ToString();

        humanIntake.transFat += Dataitem.transFat;
        TransFatSlider.value = (float)humanIntake.transFat / humanIntakeMax.transFat;
        TransFatConsumed.text = humanIntake.transFat.ToString() + "/" + humanIntakeMax.transFat.ToString();

        humanIntake.protien += Dataitem.protien;
        ProtienSlider.value = (float)humanIntake.protien / humanIntakeMax.protien;
        ProtienConsumed.text = humanIntake.protien.ToString() + "/" + humanIntakeMax.protien.ToString();

        humanIntake.cholesterol += Dataitem.cholesterol;
        CholesterolSlider.value = (float)humanIntake.cholesterol / humanIntakeMax.cholesterol;
        CholesterolConsumed.text = humanIntake.cholesterol.ToString() + "/" + humanIntakeMax.cholesterol.ToString();

        humanIntake.vitaminA += Dataitem.vitaminA;
        VitaminASlider.value = (float)humanIntake.vitaminA / humanIntakeMax.vitaminA;
        VitamimnAConsumed.text = humanIntake.vitaminA.ToString() + "/" + humanIntakeMax.vitaminA.ToString();

        humanIntake.calcium += Dataitem.calcium;
        CalciumSlider.value = (float)humanIntake.calcium / humanIntakeMax.calcium;
        Calciu7mConsumed.text = humanIntake.calcium.ToString() + "/" + humanIntakeMax.calcium.ToString();

        humanIntake.vitaminB += Dataitem.vitaminB;
        VitaminCSlider.value = (float)humanIntake.vitaminB / humanIntakeMax.vitaminB;
        VitamimnAConsumed.text = humanIntake.vitaminB.ToString() + "/" + humanIntakeMax.vitaminB.ToString();

        humanIntake.iron += Dataitem.iron;
        IronSlider.value = (float)humanIntake.iron / humanIntakeMax.iron;
        IromnmConsumed.text = humanIntake.iron.ToString() + "/" + humanIntakeMax.iron.ToString();

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
        if (humanIntake.saturatedFat >= humanIntakeMax.saturatedFat)
        {

        }
        if (humanIntake.carbohydrates >= humanIntakeMax.carbohydrates)
        {

        }
        if (humanIntake.polySaturatedFat >= humanIntakeMax.polySaturatedFat)
        {

        }
        if (humanIntake.dietaryFiber >= humanIntakeMax.dietaryFiber)
        {

        }
        if (humanIntake.monounSaturatedFat >= humanIntakeMax.monounSaturatedFat)
        {

        }
        if (humanIntake.sugars >= humanIntakeMax.sugars)
        {

        }
        if (humanIntake.transFat >= humanIntakeMax.transFat)
        {


        }
        if (humanIntake.protien >= humanIntakeMax.protien)
        {

        }
        if (humanIntake.cholesterol >= humanIntakeMax.cholesterol)
        {

        }
        if (humanIntake.vitaminA >= humanIntakeMax.vitaminA)
        {

        }
        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {

        }
        if (humanIntake.vitaminB >= humanIntakeMax.vitaminB)
        {

        }
        if (humanIntake.iron >= humanIntakeMax.iron)
        {

        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            pressIEvent();
        }
    }
    // Update is called once per frame
    public void pressIEvent()
    {
        if (sliderPanel.activeInHierarchy)
        {
            sliderPanel.SetActive(false);
        }
        else
        {
            sliderPanel.SetActive(true);       }
    }
}
