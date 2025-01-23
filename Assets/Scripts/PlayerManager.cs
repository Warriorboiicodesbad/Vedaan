using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public ItemData humanIntake;
    public ItemData humanIntakeMax;

    public PlayerData playerData;
    public TimerController timer;
    public PlayerController playerController;
    public TMP_Text dayText;

    public GameObject gameEndPanel;
    public TMP_Text gameEndPanelFeedbackTxt;
    public TMP_Text gameEndPanelLoadLevelBtnTxt;
    public Button gameEndPanelLoadLevelbtn;

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

    [Header("User Consumption Panel Progress Bar")]
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

    [Header("User Consumption Panel Percentage Texts")]
    public TMP_Text caloriesPercentageText;
    public TMP_Text sodiumPercentageText;
    public TMP_Text totalFatPercentageText;
    public TMP_Text pottasiumPercentageText;
    public TMP_Text saturatedFatPercentageText;
    public TMP_Text carbohydratesPercentageText;
    public TMP_Text polySaturatedFatPercentageText;
    public TMP_Text dietaryFibrePercentageText;
    public TMP_Text monounSaturatedFatPercentageText;
    public TMP_Text sugarPercentageText;
    public TMP_Text transFatPercentageText;
    public TMP_Text proteinPercentageText;
    public TMP_Text cholestrolPercentageText;
    public TMP_Text vitaminAPercentageText;
    public TMP_Text calciumPercentageText;
    public TMP_Text vitaminCPercentageText;
    public TMP_Text ironPercentageText;

    [Header("Panel References")]
    public GameObject userConsumptionPanel;
    public GameObject itemInformationPanel;
    public GameObject instructionPanel;


    private bool hasConsumedAll = false;


    private void Start()
    {
        PressEAction(humanIntake);
    }

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
        float fillRatio = 0;

        humanIntake.calories += itemData.calories;
        fillRatio = (float)humanIntake.calories / humanIntakeMax.calories;
        CalorieProgressBar.fillAmount = fillRatio;
        caloriesPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        caloriesConsumedCount.text = humanIntake.calories.ToString() + "/" + humanIntakeMax.calories.ToString()+"kcal";

        humanIntake.sodium += itemData.sodium;
        fillRatio = (float)humanIntake.calories / humanIntakeMax.calories;
        SodiumProgressBar.fillAmount = fillRatio;
        sodiumPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        sodiumConsumedCount.text = humanIntake.sodium.ToString() + "/" + humanIntakeMax.sodium.ToString()+ "mg";

        humanIntake.totalFat += itemData.totalFat;
        fillRatio = (float)humanIntake.totalFat / humanIntakeMax.totalFat;
        TotalFatProgressBar.fillAmount = fillRatio;
        totalFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        totalFatConsumedCount.text = humanIntake.totalFat.ToString() + "/" + humanIntakeMax.totalFat.ToString()+ "g";

        humanIntake.potassium += itemData.potassium;
        fillRatio = (float)humanIntake.potassium / humanIntakeMax.potassium;
        PottasiumProgressBar.fillAmount = fillRatio;
        pottasiumPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        pottasiumConsumedCount.text = humanIntake.potassium.ToString() + "/" + humanIntakeMax.potassium.ToString();
        
        humanIntake.saturatedFat += itemData.saturatedFat;
        fillRatio = (float)humanIntake.saturatedFat / humanIntakeMax.saturatedFat;
        SaturatedFatProgressBar.fillAmount = fillRatio;
        saturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        saturatedFatConsumedCount.text = humanIntake.saturatedFat.ToString() + "/" + humanIntakeMax.saturatedFat.ToString();

        humanIntake.carbohydrates += itemData.carbohydrates;
        fillRatio = (float)humanIntake.carbohydrates / humanIntakeMax.carbohydrates;
        CarbohydratesProgressBar.fillAmount = fillRatio;
        carbohydratesPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        carbohydratesConsumedCount.text = humanIntake.carbohydrates.ToString() + "/" + humanIntakeMax.carbohydrates.ToString();

        humanIntake.polySaturatedFat += itemData.polySaturatedFat;
        fillRatio = (float)humanIntake.polySaturatedFat / humanIntakeMax.polySaturatedFat;
        PolySaturatedFatProgressBar.fillAmount = fillRatio;
        polySaturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        polySaturatedFatConsumedCount.text = humanIntake.polySaturatedFat.ToString() + "/" + humanIntakeMax.polySaturatedFat.ToString();

        humanIntake.dietaryFiber += itemData.dietaryFiber;
        fillRatio = (float)humanIntake.dietaryFiber / humanIntakeMax.dietaryFiber;
        DietaryFiberProgressBar.fillAmount = fillRatio;
        dietaryFibrePercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        dietaryFiberConsumedCount.text = humanIntake.dietaryFiber.ToString() + "/" + humanIntakeMax.dietaryFiber.ToString();

        humanIntake.monounSaturatedFat += itemData.monounSaturatedFat;
        fillRatio = (float)humanIntake.monounSaturatedFat / humanIntakeMax.monounSaturatedFat;
        MonounSaturatedFatProgressBar.fillAmount = fillRatio;
        monounSaturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        monounSaturatedFatConsumedCount.text = humanIntake.monounSaturatedFat.ToString() + "/" + humanIntakeMax.monounSaturatedFat.ToString();
        
        humanIntake.sugars += itemData.sugars;
        fillRatio = (float)humanIntake.sugars / humanIntakeMax.sugars;
        SugarProgressBar.fillAmount = fillRatio;
        sugarPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        sugarConsumedCount.text = humanIntake.sugars.ToString() + "/" + humanIntakeMax.sugars.ToString();

        humanIntake.transFat += itemData.transFat;
        fillRatio = (float)humanIntake.transFat / humanIntakeMax.transFat;
        TransFatProgressBar.fillAmount = fillRatio;
        transFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        transFatConsumedCount.text = humanIntake.transFat.ToString() + "/" + humanIntakeMax.transFat.ToString();

        humanIntake.protien += itemData.protien;
        fillRatio = (float)humanIntake.protien / humanIntakeMax.protien;
        ProteinProgressBar.fillAmount = fillRatio;
        proteinPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        proteinConsumedCount.text = humanIntake.protien.ToString() + "/" + humanIntakeMax.protien.ToString();

        humanIntake.cholesterol += itemData.cholesterol;
        fillRatio = (float)humanIntake.cholesterol / humanIntakeMax.cholesterol;
        CholesterolProgressBar.fillAmount = fillRatio;
        cholestrolPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        cholesterolConsumedCount.text = humanIntake.cholesterol.ToString() + "/" + humanIntakeMax.cholesterol.ToString();

        humanIntake.vitaminA += itemData.vitaminA;
        fillRatio = (float)humanIntake.vitaminA / humanIntakeMax.vitaminA;
        VitaminAProgressBar.fillAmount = fillRatio;
        vitaminAPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        vitaminAConsumedCount.text = humanIntake.vitaminA.ToString() + "/" + humanIntakeMax.vitaminA.ToString();

        humanIntake.calcium += itemData.calcium;
        fillRatio = (float)humanIntake.calcium / humanIntakeMax.calcium;
        CalciumProgressBar.fillAmount = fillRatio;
        calciumPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        calciumConsumedCount.text = humanIntake.calcium.ToString() + "/" + humanIntakeMax.calcium.ToString();

        humanIntake.vitaminB += itemData.vitaminB;
        fillRatio = (float)humanIntake.vitaminB / humanIntakeMax.vitaminB;
        VitaminCProgressBar.fillAmount = fillRatio;
        vitaminCPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        vitaminCConsumedCount.text = humanIntake.vitaminB.ToString() + "/" + humanIntakeMax.vitaminB.ToString();

        humanIntake.iron += itemData.iron;
        fillRatio = (float)humanIntake.iron / humanIntakeMax.iron;
        IronProgressBar.fillAmount = fillRatio;
        ironPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        ironConsumedCount.text = humanIntake.iron.ToString() + "/" + humanIntakeMax.iron.ToString();

        bool checkConsumedAll = true;
        if (humanIntake.calories >= humanIntakeMax.calories)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.sodium >= humanIntakeMax.sodium)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.totalFat >= humanIntakeMax.totalFat)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.potassium >= humanIntakeMax.potassium)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.saturatedFat >= humanIntakeMax.saturatedFat)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.carbohydrates >= humanIntakeMax.carbohydrates)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.polySaturatedFat >= humanIntakeMax.polySaturatedFat)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.dietaryFiber >= humanIntakeMax.dietaryFiber)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.monounSaturatedFat >= humanIntakeMax.monounSaturatedFat)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.sugars >= humanIntakeMax.sugars)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.transFat >= humanIntakeMax.transFat)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.protien >= humanIntakeMax.protien)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.cholesterol >= humanIntakeMax.cholesterol)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.vitaminA >= humanIntakeMax.vitaminA)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.vitaminB >= humanIntakeMax.vitaminB)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if (humanIntake.iron >= humanIntakeMax.iron)
        {
            checkConsumedAll &= true;
        }
        else
        {
            checkConsumedAll &= false;
        }

        if(checkConsumedAll)
        {
            hasConsumedAll = checkConsumedAll;
            OnGameOver();
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

    public void OnGameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        gameEndPanel.SetActive(true);
        if(hasConsumedAll)
        {
            gameEndPanelFeedbackTxt.text = "You intake was completed.";
            gameEndPanelLoadLevelBtnTxt.text = "Start Next Day";

            // Disable Player Controller
            playerController.enabled = false;
            // Save CurrentDay's Data
            CopyItemData(humanIntake, playerData.GetCurrentDayData());

            //IncrementDay
            playerData.day++;

            if (playerData.day > playerData.maxDays)
            {
                gameEndPanelLoadLevelbtn.interactable = false;
                gameEndPanelLoadLevelBtnTxt.text = "No More Levels to Load";
            }
        }
        else
        {
            gameEndPanelFeedbackTxt.text = "You intake was not completed.";
            gameEndPanelLoadLevelBtnTxt.text = "Reload current Day";
        }
    }

    private void CopyItemData(ItemData source, ItemData target)
    {
        string json = JsonUtility.ToJson(source);
        JsonUtility.FromJsonOverwrite(json, target);
    }

    public void LoadLevel()
    {
        humanIntake.ResetValues();
        PressEAction(humanIntake);
        playerController.enabled = true;
        dayText.text = $"Day {playerData.day}";

        //Disable Panel

        //Start Timer
        timer.StartTimer();
        gameEndPanel.SetActive(false);
    }
}
