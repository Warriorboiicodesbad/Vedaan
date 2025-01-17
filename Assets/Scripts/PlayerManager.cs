using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public ItemData humanIntake;
    public ItemData humanIntakeMax;

    [Header("Item Information Panel Texts")]
    public TMP_Text itemNameTxt;
    public TMP_Text itemCaloriesCount;
    public TMP_Text itemSodiumCount;
    public TMP_Text itemTotalFatCount;
    public TMP_Text itemPottasiumCount;
    public TMP_Text itemSaturatedFatCount;
    public TMP_Text itemCarbohydratesCount;
    public TMP_Text itemPolySaturatedFatCount;
    public TMP_Text itemDietaryFiberCount;
    public TMP_Text itemMonounSaturatedFatCount;
    public TMP_Text itemSugarsCount;
    public TMP_Text itemTransFatCount;
    public TMP_Text itemProtienCount;
    public TMP_Text itemCholesterolCount;
    public TMP_Text itemVitamimnACount;
    public TMP_Text itemCalciumCount;
    public TMP_Text itemVitaminCCount;
    public TMP_Text itemIronCount;

    [Header("User Consumption Panel Texts")]
    public TMP_Text caloriesConsumedCount;
    public TMP_Text sodiumConsumedCount;
    public TMP_Text totalFatConsumedCount;
    public TMP_Text pottasiumConsumedCount;
    public TMP_Text saturatedFatConsumedCount;
    public TMP_Text carbohydratesConsumedCount;
    public TMP_Text polySaturatedFatConsumedCount;
    public TMP_Text dietaryFiberConsumedCount;
    public TMP_Text monounSaturatedFatConsumedCount;
    public TMP_Text sugarConsumedCount;
    public TMP_Text transFatConsumedCount;
    public TMP_Text proteinConsumedCount;
    public TMP_Text cholesterolConsumedCount;
    public TMP_Text vitaminAConsumedCount;
    public TMP_Text calciumConsumedCount;
    public TMP_Text vitaminCConsumedCount;
    public TMP_Text ironConsumedCount;

    [Header("User Consumption Panel Sliders")]
    public Image CalorieProgressBar;
    public Image SodiumProgressBar;
    public Image TotalFatProgressBar;
    public Image PottasiumProgressBar;
    public Image SaturatedFatProgressBar;
    public Image CarbohydratesProgressBar;
    public Image PolySaturatedFatProgressBar;
    public Image DietaryFiberProgressBar;
    public Image MonounSaturatedFatProgressBar;
    public Image SugarProgressBar;
    public Image TransFatProgressBar;
    public Image ProteinProgressBar;
    public Image CholesterolProgressBar;
    public Image VitaminAProgressBar;
    public Image CalciumProgressBar;
    public Image VitaminCProgressBar;
    public Image IronProgressBar;

    [Header("Panel References")]
    public GameObject userConsumptionPanel;
    public GameObject itemInformationPanel;
    public GameObject instructionPanel;

    public void ShowUserConsumptionPanel(ItemData itemData)
    {
        itemNameTxt.text = itemData.name;
        itemCaloriesCount.text = itemData.calories.ToString();
        itemSodiumCount.text = itemData.sodium.ToString();
        itemTotalFatCount.text = itemData.totalFat.ToString();
        itemPottasiumCount.text = itemData.potassium.ToString();
        itemSaturatedFatCount.text = itemData.saturatedFat.ToString();
        itemCarbohydratesCount.text = itemData.carbohydrates.ToString();
        itemPolySaturatedFatCount.text = itemData.polySaturatedFat.ToString();
        itemDietaryFiberCount.text = itemData.dietaryFiber.ToString();
        itemMonounSaturatedFatCount.text = itemData.monounSaturatedFat.ToString();
        itemSugarsCount.text = itemData.sugars.ToString();
        itemTransFatCount.text = itemData.transFat.ToString();
        itemProtienCount.text = itemData.protien.ToString();
        itemCholesterolCount.text = itemData.cholesterol.ToString();
        itemVitamimnACount.text = itemData.vitaminA.ToString();
        itemCalciumCount.text = itemData.calcium.ToString();
        itemVitaminCCount.text = itemData.vitaminB.ToString();
        itemIronCount.text = itemData.iron.ToString();

        itemInformationPanel.SetActive(true);
    }
    public void PressEAction(ItemData itemData)
    {
        humanIntake.calories += itemData.calories;
        CalorieProgressBar.fillAmount = (float)humanIntake.calories / humanIntakeMax.calories;
        caloriesConsumedCount.text = humanIntake.calories.ToString() + "/" + humanIntakeMax.calories.ToString();

        humanIntake.sodium += itemData.sodium;
        SodiumProgressBar.fillAmount = (float)humanIntake.calories / humanIntakeMax.calories;
        sodiumConsumedCount.text = humanIntake.sodium.ToString() + "/" + humanIntakeMax.sodium.ToString();

        humanIntake.totalFat += itemData.totalFat;
        TotalFatProgressBar.fillAmount = (float)humanIntake.totalFat / humanIntakeMax.totalFat;
        totalFatConsumedCount.text = humanIntake.totalFat.ToString() + "/" + humanIntakeMax.totalFat.ToString();

        humanIntake.potassium += itemData.potassium;
        PottasiumProgressBar.fillAmount = (float)humanIntake.potassium / humanIntakeMax.potassium;
        pottasiumConsumedCount.text = humanIntake.potassium.ToString() + "/" + humanIntakeMax.potassium.ToString();
        
        humanIntake.saturatedFat += itemData.saturatedFat;
        SaturatedFatProgressBar.fillAmount = (float)humanIntake.saturatedFat / humanIntakeMax.saturatedFat;
        saturatedFatConsumedCount.text = humanIntake.saturatedFat.ToString() + "/" + humanIntakeMax.saturatedFat.ToString();

        humanIntake.carbohydrates += itemData.carbohydrates;
        CarbohydratesProgressBar.fillAmount = (float)humanIntake.carbohydrates / humanIntakeMax.carbohydrates;
        carbohydratesConsumedCount.text = humanIntake.carbohydrates.ToString() + "/" + humanIntakeMax.carbohydrates.ToString();

        humanIntake.polySaturatedFat += itemData.polySaturatedFat;
        PolySaturatedFatProgressBar.fillAmount = (float)humanIntake.polySaturatedFat / humanIntakeMax.polySaturatedFat;
        polySaturatedFatConsumedCount.text = humanIntake.polySaturatedFat.ToString() + "/" + humanIntakeMax.polySaturatedFat.ToString();

        humanIntake.dietaryFiber += itemData.dietaryFiber;
        DietaryFiberProgressBar.fillAmount = (float)humanIntake.dietaryFiber / humanIntakeMax.dietaryFiber;
        dietaryFiberConsumedCount.text = humanIntake.dietaryFiber.ToString() + "/" + humanIntakeMax.dietaryFiber.ToString();

        humanIntake.monounSaturatedFat += itemData.monounSaturatedFat;
        MonounSaturatedFatProgressBar.fillAmount = (float)humanIntake.monounSaturatedFat / humanIntakeMax.monounSaturatedFat;
        monounSaturatedFatConsumedCount.text = humanIntake.monounSaturatedFat.ToString() + "/" + humanIntakeMax.monounSaturatedFat.ToString();
        
        humanIntake.sugars += itemData.sugars;
        SugarProgressBar.fillAmount = (float)humanIntake.sugars / humanIntakeMax.sugars;
        sugarConsumedCount.text = humanIntake.sugars.ToString() + "/" + humanIntakeMax.sugars.ToString();

        humanIntake.transFat += itemData.transFat;
        TransFatProgressBar.fillAmount = (float)humanIntake.transFat / humanIntakeMax.transFat;
        transFatConsumedCount.text = humanIntake.transFat.ToString() + "/" + humanIntakeMax.transFat.ToString();

        humanIntake.protien += itemData.protien;
        ProteinProgressBar.fillAmount = (float)humanIntake.protien / humanIntakeMax.protien;
        proteinConsumedCount.text = humanIntake.protien.ToString() + "/" + humanIntakeMax.protien.ToString();

        humanIntake.cholesterol += itemData.cholesterol;
        CholesterolProgressBar.fillAmount = (float)humanIntake.cholesterol / humanIntakeMax.cholesterol;
        cholesterolConsumedCount.text = humanIntake.cholesterol.ToString() + "/" + humanIntakeMax.cholesterol.ToString();

        humanIntake.vitaminA += itemData.vitaminA;
        VitaminAProgressBar.fillAmount = (float)humanIntake.vitaminA / humanIntakeMax.vitaminA;
        vitaminAConsumedCount.text = humanIntake.vitaminA.ToString() + "/" + humanIntakeMax.vitaminA.ToString();

        humanIntake.calcium += itemData.calcium;
        CalciumProgressBar.fillAmount = (float)humanIntake.calcium / humanIntakeMax.calcium;
        calciumConsumedCount.text = humanIntake.calcium.ToString() + "/" + humanIntakeMax.calcium.ToString();

        humanIntake.vitaminB += itemData.vitaminB;
        VitaminCProgressBar.fillAmount = (float)humanIntake.vitaminB / humanIntakeMax.vitaminB;
        vitaminCConsumedCount.text = humanIntake.vitaminB.ToString() + "/" + humanIntakeMax.vitaminB.ToString();

        humanIntake.iron += itemData.iron;
        IronProgressBar.fillAmount = (float)humanIntake.iron / humanIntakeMax.iron;
        ironConsumedCount.text = humanIntake.iron.ToString() + "/" + humanIntakeMax.iron.ToString();

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

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            PressIAction();
        }
    }

    public void PressIAction()
    {
        if (userConsumptionPanel.activeInHierarchy)
        {
            userConsumptionPanel.SetActive(false);
        }
        else
        {
            userConsumptionPanel.SetActive(true);       
        }
    }

    public void OnRayCastHitAction(ItemData itemData)
    {
        instructionPanel.SetActive(true);
        ShowUserConsumptionPanel(itemData);

        if (Input.GetKeyDown(KeyCode.E))
        {
            PressEAction(itemData);
        }
    }

    public void OnNoRaycastHitAction()
    {
        instructionPanel.SetActive(false);
        itemInformationPanel.SetActive(false);
    }
}
