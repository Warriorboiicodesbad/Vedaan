using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public ItemData humanIntake;
    public ItemData humanIntakeMax;
    public List<ItemData> daysIntakeData;

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
    public CanvasGroup userConsumptionCG;
    public GameObject itemInformationPanel;
    public GameObject instructionPanel;
    public ItemData emptyItem;

    [SerializeField] TMP_Text consumptionTxt, dayTxt;

    private bool isRunningConsumptionPanelAnimation = false;
    public float totalConsumptionPercentage = 0f;

    private void Start()
    {
        AddConsumeItem(emptyItem);
        dayTxt.text = $"Day {GameData.currentLevel.ToString()}";
    }

    private void OnEnable()
    {
        GameData.OnTimerOver.AddListener(OnTimerOver);
    }

    private void OnDisable()
    {
        GameData.OnTimerOver.RemoveListener(OnTimerOver);
    }

    private void OnTimerOver()
    {
        humanIntake = ScriptableObject.CreateInstance<ItemData>();
        SceneManager.LoadScene("Timeover");
    }

    public void ShowItemInformationPanel(ItemData itemData)
    {
        itemNameTxt.text = itemData.name;
        itemCaloriesCount.text = itemData.calories.ToString();
        itemSodiumCount.text = itemData.sodium.ToString();
        itemTotalFatCount.text = itemData.totalFat.ToString();
        itemPottasiumCount.text = itemData.potassium.ToString();
        //itemSaturatedFatCount.text = itemData.saturatedFat.ToString();
        itemCarbohydratesCount.text = itemData.carbohydrates.ToString();
        //itemPolySaturatedFatCount.text = itemData.polySaturatedFat.ToString();
        //itemDietaryFiberCount.text = itemData.dietaryFiber.ToString();
        //itemMonounSaturatedFatCount.text = itemData.monounSaturatedFat.ToString();
        //itemSugarsCount.text = itemData.sugars.ToString();
        //itemTransFatCount.text = itemData.transFat.ToString();
        itemProtienCount.text = itemData.protien.ToString();
        itemCholesterolCount.text = itemData.cholesterol.ToString();
        itemVitamimnACount.text = itemData.vitaminA.ToString();
        itemCalciumCount.text = itemData.calcium.ToString();
        itemVitaminCCount.text = itemData.vitaminB.ToString();
        itemIronCount.text = itemData.iron.ToString();

        itemInformationPanel.SetActive(true);
    }

    public void AddConsumeItem(ItemData itemData)
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
        
        //humanIntake.saturatedFat += itemData.saturatedFat;
        //fillRatio = (float)humanIntake.saturatedFat / humanIntakeMax.saturatedFat;
        //SaturatedFatProgressBar.fillAmount = fillRatio;
        //saturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //saturatedFatConsumedCount.text = humanIntake.saturatedFat.ToString() + "/" + humanIntakeMax.saturatedFat.ToString();

        humanIntake.carbohydrates += itemData.carbohydrates;
        fillRatio = (float)humanIntake.carbohydrates / humanIntakeMax.carbohydrates;
        CarbohydratesProgressBar.fillAmount = fillRatio;
        carbohydratesPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        carbohydratesConsumedCount.text = humanIntake.carbohydrates.ToString() + "/" + humanIntakeMax.carbohydrates.ToString();

        //humanIntake.polySaturatedFat += itemData.polySaturatedFat;
        //fillRatio = (float)humanIntake.polySaturatedFat / humanIntakeMax.polySaturatedFat;
        //PolySaturatedFatProgressBar.fillAmount = fillRatio;
        //polySaturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //polySaturatedFatConsumedCount.text = humanIntake.polySaturatedFat.ToString() + "/" + humanIntakeMax.polySaturatedFat.ToString();

        //humanIntake.dietaryFiber += itemData.dietaryFiber;
        //fillRatio = (float)humanIntake.dietaryFiber / humanIntakeMax.dietaryFiber;
        //DietaryFiberProgressBar.fillAmount = fillRatio;
        //dietaryFibrePercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //dietaryFiberConsumedCount.text = humanIntake.dietaryFiber.ToString() + "/" + humanIntakeMax.dietaryFiber.ToString();

        //humanIntake.monounSaturatedFat += itemData.monounSaturatedFat;
        //fillRatio = (float)humanIntake.monounSaturatedFat / humanIntakeMax.monounSaturatedFat;
        //MonounSaturatedFatProgressBar.fillAmount = fillRatio;
        //monounSaturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //monounSaturatedFatConsumedCount.text = humanIntake.monounSaturatedFat.ToString() + "/" + humanIntakeMax.monounSaturatedFat.ToString();
        
        //humanIntake.sugars += itemData.sugars;
        //fillRatio = (float)humanIntake.sugars / humanIntakeMax.sugars;
        //SugarProgressBar.fillAmount = fillRatio;
        //sugarPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //sugarConsumedCount.text = humanIntake.sugars.ToString() + "/" + humanIntakeMax.sugars.ToString();

        //humanIntake.transFat += itemData.transFat;
        //fillRatio = (float)humanIntake.transFat / humanIntakeMax.transFat;
        //TransFatProgressBar.fillAmount = fillRatio;
        //transFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //transFatConsumedCount.text = humanIntake.transFat.ToString() + "/" + humanIntakeMax.transFat.ToString();

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
        //if (humanIntake.saturatedFat >= humanIntakeMax.saturatedFat)
        //{

        //}
        if (humanIntake.carbohydrates >= humanIntakeMax.carbohydrates)
        {

        }
        //if (humanIntake.polySaturatedFat >= humanIntakeMax.polySaturatedFat)
        //{

        //}
        //if (humanIntake.dietaryFiber >= humanIntakeMax.dietaryFiber)
        //{

        //}
        //if (humanIntake.monounSaturatedFat >= humanIntakeMax.monounSaturatedFat)
        //{

        //}
        //if (humanIntake.sugars >= humanIntakeMax.sugars)
        //{

        //}
        //if (humanIntake.transFat >= humanIntakeMax.transFat)
        //{


        //}
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

        AnimateUserConsumption();

        if (CheckCanConsumeItems())
        {
            consumptionTxt.text = $"Consumption Complete : {totalConsumptionPercentage}";
            consumptionTxt.color = Color.green;
        }
        else
        {
            consumptionTxt.text = $"Consumption Incomplete : {totalConsumptionPercentage}";
            consumptionTxt.color = Color.red;
        }
    }

    public void RemoveConsumeItem(ItemData itemData)
    {
        float fillRatio = 0;

        humanIntake.calories -= itemData.calories;
        fillRatio = (float)humanIntake.calories / humanIntakeMax.calories;
        CalorieProgressBar.fillAmount = fillRatio;
        caloriesPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        caloriesConsumedCount.text = humanIntake.calories.ToString() + "/" + humanIntakeMax.calories.ToString() + "kcal";

        humanIntake.sodium -= itemData.sodium;
        fillRatio = (float)humanIntake.calories / humanIntakeMax.calories;
        SodiumProgressBar.fillAmount = fillRatio;
        sodiumPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        sodiumConsumedCount.text = humanIntake.sodium.ToString() + "/" + humanIntakeMax.sodium.ToString() + "mg";

        humanIntake.totalFat -= itemData.totalFat;
        fillRatio = (float)humanIntake.totalFat / humanIntakeMax.totalFat;
        TotalFatProgressBar.fillAmount = fillRatio;
        totalFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        totalFatConsumedCount.text = humanIntake.totalFat.ToString() + "/" + humanIntakeMax.totalFat.ToString() + "g";

        humanIntake.potassium -= itemData.potassium;
        fillRatio = (float)humanIntake.potassium / humanIntakeMax.potassium;
        PottasiumProgressBar.fillAmount = fillRatio;
        pottasiumPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        pottasiumConsumedCount.text = humanIntake.potassium.ToString() + "/" + humanIntakeMax.potassium.ToString();

        //humanIntake.saturatedFat -= itemData.saturatedFat;
        //fillRatio = (float)humanIntake.saturatedFat / humanIntakeMax.saturatedFat;
        //SaturatedFatProgressBar.fillAmount = fillRatio;
        //saturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //saturatedFatConsumedCount.text = humanIntake.saturatedFat.ToString() + "/" + humanIntakeMax.saturatedFat.ToString();

        humanIntake.carbohydrates -= itemData.carbohydrates;
        fillRatio = (float)humanIntake.carbohydrates / humanIntakeMax.carbohydrates;
        CarbohydratesProgressBar.fillAmount = fillRatio;
        carbohydratesPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        carbohydratesConsumedCount.text = humanIntake.carbohydrates.ToString() + "/" + humanIntakeMax.carbohydrates.ToString();

        //humanIntake.polySaturatedFat -= itemData.polySaturatedFat;
        //fillRatio = (float)humanIntake.polySaturatedFat / humanIntakeMax.polySaturatedFat;
        //PolySaturatedFatProgressBar.fillAmount = fillRatio;
        //polySaturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //polySaturatedFatConsumedCount.text = humanIntake.polySaturatedFat.ToString() + "/" + humanIntakeMax.polySaturatedFat.ToString();

        //humanIntake.dietaryFiber -= itemData.dietaryFiber;
        //fillRatio = (float)humanIntake.dietaryFiber / humanIntakeMax.dietaryFiber;
        //DietaryFiberProgressBar.fillAmount = fillRatio;
        //dietaryFibrePercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //dietaryFiberConsumedCount.text = humanIntake.dietaryFiber.ToString() + "/" + humanIntakeMax.dietaryFiber.ToString();

        //humanIntake.monounSaturatedFat -= itemData.monounSaturatedFat;
        //fillRatio = (float)humanIntake.monounSaturatedFat / humanIntakeMax.monounSaturatedFat;
        //MonounSaturatedFatProgressBar.fillAmount = fillRatio;
        //monounSaturatedFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //monounSaturatedFatConsumedCount.text = humanIntake.monounSaturatedFat.ToString() + "/" + humanIntakeMax.monounSaturatedFat.ToString();

        //humanIntake.sugars -= itemData.sugars;
        //fillRatio = (float)humanIntake.sugars / humanIntakeMax.sugars;
        //SugarProgressBar.fillAmount = fillRatio;
        //sugarPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //sugarConsumedCount.text = humanIntake.sugars.ToString() + "/" + humanIntakeMax.sugars.ToString();

        //humanIntake.transFat -= itemData.transFat;
        //fillRatio = (float)humanIntake.transFat / humanIntakeMax.transFat;
        //TransFatProgressBar.fillAmount = fillRatio;
        //transFatPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        //transFatConsumedCount.text = humanIntake.transFat.ToString() + "/" + humanIntakeMax.transFat.ToString();

        humanIntake.protien -= itemData.protien;
        fillRatio = (float)humanIntake.protien / humanIntakeMax.protien;
        ProteinProgressBar.fillAmount = fillRatio;
        proteinPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        proteinConsumedCount.text = humanIntake.protien.ToString() + "/" + humanIntakeMax.protien.ToString();

        humanIntake.cholesterol -= itemData.cholesterol;
        fillRatio = (float)humanIntake.cholesterol / humanIntakeMax.cholesterol;
        CholesterolProgressBar.fillAmount = fillRatio;
        cholestrolPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        cholesterolConsumedCount.text = humanIntake.cholesterol.ToString() + "/" + humanIntakeMax.cholesterol.ToString();

        humanIntake.vitaminA -= itemData.vitaminA;
        fillRatio = (float)humanIntake.vitaminA / humanIntakeMax.vitaminA;
        VitaminAProgressBar.fillAmount = fillRatio;
        vitaminAPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        vitaminAConsumedCount.text = humanIntake.vitaminA.ToString() + "/" + humanIntakeMax.vitaminA.ToString();

        humanIntake.calcium -= itemData.calcium;
        fillRatio = (float)humanIntake.calcium / humanIntakeMax.calcium;
        CalciumProgressBar.fillAmount = fillRatio;
        calciumPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        calciumConsumedCount.text = humanIntake.calcium.ToString() + "/" + humanIntakeMax.calcium.ToString();

        humanIntake.vitaminB -= itemData.vitaminB;
        fillRatio = (float)humanIntake.vitaminB / humanIntakeMax.vitaminB;
        VitaminCProgressBar.fillAmount = fillRatio;
        vitaminCPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
        vitaminCConsumedCount.text = humanIntake.vitaminB.ToString() + "/" + humanIntakeMax.vitaminB.ToString();

        humanIntake.iron -= itemData.iron;
        fillRatio = (float)humanIntake.iron / humanIntakeMax.iron;
        IronProgressBar.fillAmount = fillRatio;
        ironPercentageText.text = $"{((int)(fillRatio * 100)).ToString()}%";
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
        //if (humanIntake.saturatedFat >= humanIntakeMax.saturatedFat)
        //{

        //}
        if (humanIntake.carbohydrates >= humanIntakeMax.carbohydrates)
        {

        }
        //if (humanIntake.polySaturatedFat >= humanIntakeMax.polySaturatedFat)
        //{

        //}
        //if (humanIntake.dietaryFiber >= humanIntakeMax.dietaryFiber)
        //{

        //}
        //if (humanIntake.monounSaturatedFat >= humanIntakeMax.monounSaturatedFat)
        //{

        //}
        //if (humanIntake.sugars >= humanIntakeMax.sugars)
        //{

        //}
        //if (humanIntake.transFat >= humanIntakeMax.transFat)
        //{


        //}
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

        AnimateUserConsumption();

        if (CheckCanConsumeItems())
        {
            consumptionTxt.text = $"Consumption Complete : {totalConsumptionPercentage}";
            consumptionTxt.color = Color.green;
        }
        else
        {
            consumptionTxt.text = $"Consumption Incomplete : {totalConsumptionPercentage}";
            consumptionTxt.color = Color.red;
        }
    }

    public void AnimateUserConsumption()
    {
        if (isRunningConsumptionPanelAnimation) return;

        isRunningConsumptionPanelAnimation = true;

        userConsumptionCG.DOFade(1, 1f).OnComplete(
            () => 
            {
                userConsumptionCG.DOFade(1, 2f).OnComplete(
                    () =>
                    {
                        userConsumptionCG.DOFade(0, 1f).OnComplete(
                            () =>
                            {
                                isRunningConsumptionPanelAnimation = false;
                            }
                        );
                    }
                    );
            }
        );
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            ShowUserConsumptionPanel();
        }
    }

    public void ShowUserConsumptionPanel()
    {
        if (isRunningConsumptionPanelAnimation) return;

        userConsumptionCG.alpha = userConsumptionCG.alpha == 1 ? 0 : 1;
    }

    public bool CheckCanConsumeItems()
    {
        float totalPercentage = 0f;

        if (humanIntake.calories >= humanIntakeMax.calories)
        {
            totalPercentage += ((humanIntake.calories - humanIntakeMax.calories) / humanIntakeMax.calories) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.calories - humanIntake.calories) / humanIntakeMax.calories) * 100;
        }

        if (humanIntake.sodium >= humanIntakeMax.sodium)
        {
            totalPercentage += ((humanIntake.sodium - humanIntakeMax.sodium) / humanIntakeMax.sodium) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.sodium - humanIntake.sodium) / humanIntakeMax.sodium) * 100;
        }

        if (humanIntake.totalFat >= humanIntakeMax.totalFat)
        {
            totalPercentage += ((humanIntake.totalFat - humanIntakeMax.totalFat) / humanIntakeMax.totalFat) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.totalFat - humanIntake.totalFat) / humanIntakeMax.totalFat) * 100;    
        }

        if (humanIntake.potassium >= humanIntakeMax.potassium)
        {
            totalPercentage += ((humanIntake.potassium - humanIntakeMax.potassium) / humanIntakeMax.potassium) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.potassium - humanIntake.potassium) / humanIntakeMax.potassium) * 100;    
        }
        //if (humanIntake.saturatedFat >= humanIntakeMax.saturatedFat)
        //{
        //    consumptionComplete &= true;
        //}
        //else
        //{
        //    consumptionComplete &= false;    
        //}
        if (humanIntake.carbohydrates >= humanIntakeMax.carbohydrates)
        {
            totalPercentage += ((humanIntake.carbohydrates - humanIntakeMax.carbohydrates) / humanIntakeMax.carbohydrates) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.carbohydrates - humanIntake.carbohydrates) / humanIntakeMax.carbohydrates) * 100;    
        }
        //if (humanIntake.polySaturatedFat >= humanIntakeMax.polySaturatedFat)
        //{
        //    consumptionComplete &= true;
        //}
        //else
        //{
        //    consumptionComplete &= false;    
        //}
        //if (humanIntake.dietaryFiber >= humanIntakeMax.dietaryFiber)
        //{
        //    consumptionComplete &= true;
        //}
        //else
        //{
        //    consumptionComplete &= false;    
        //}
        //if (humanIntake.monounSaturatedFat >= humanIntakeMax.monounSaturatedFat)
        //{
        //    consumptionComplete &= true;
        //}
        //else
        //{
        //    consumptionComplete &= false;    
        //}
        //if (humanIntake.sugars >= humanIntakeMax.sugars)
        //{
        //    consumptionComplete &= true;
        //}
        //else
        //{
        //    consumptionComplete &= false;    
        //}
        //if (humanIntake.transFat >= humanIntakeMax.transFat)
        //{
        //    consumptionComplete &= true;
        //}
        //else
        //{
        //    consumptionComplete &= false;
        //}
        if (humanIntake.protien >= humanIntakeMax.protien)
        {
            totalPercentage += ((humanIntake.protien - humanIntakeMax.protien) / humanIntakeMax.protien) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.protien - humanIntake.protien) / humanIntakeMax.protien) * 100;    
        }


        if (humanIntake.cholesterol >= humanIntakeMax.cholesterol)
        {
            totalPercentage += ((humanIntake.cholesterol - humanIntakeMax.cholesterol) / humanIntakeMax.cholesterol) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.cholesterol - humanIntake.cholesterol) / humanIntakeMax.cholesterol) * 100;    
        }

        if (humanIntake.vitaminA >= humanIntakeMax.vitaminA)
        {
            totalPercentage += ((humanIntake.vitaminA - humanIntakeMax.vitaminA) / humanIntakeMax.vitaminA) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.vitaminA - humanIntake.vitaminA) / humanIntakeMax.vitaminA) * 100;    
        }


        if (humanIntake.calcium >= humanIntakeMax.calcium)
        {
            totalPercentage += ((humanIntake.calcium - humanIntakeMax.calcium) / humanIntakeMax.calcium) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.calcium - humanIntake.calcium) / humanIntakeMax.calcium) * 100;    
        }

        if (humanIntake.vitaminB >= humanIntakeMax.vitaminB)
        {
            totalPercentage += ((humanIntake.vitaminB - humanIntakeMax.vitaminB) / humanIntakeMax.vitaminB) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.vitaminB - humanIntake.vitaminB) / humanIntakeMax.vitaminB) * 100;    
        }


        if (humanIntake.iron >= humanIntakeMax.iron)
        {
            totalPercentage += ((humanIntake.iron - humanIntakeMax.iron) / humanIntakeMax.iron) * 100;
        }
        else
        {
            totalPercentage += ((humanIntakeMax.iron - humanIntake.iron) / humanIntakeMax.iron) * 100;    
        }

        totalPercentage /= 11;

        totalConsumptionPercentage = totalPercentage;

        if (totalPercentage > 75f) return false;
        else return true;
    }

    public void ConsumeItems()
    {
        if (CheckCanConsumeItems())
        {
            GameData.CopyScriptableObjectData(humanIntake, daysIntakeData[GameData.currentLevel - 1]);
            humanIntake.calories = 0;
            humanIntake.calcium = 0;
            humanIntake.vitaminB = 0;
            humanIntake.carbohydrates = 0;
            humanIntake.cholesterol = 0;
            humanIntake.iron = 0;
            humanIntake.protien = 0;
            humanIntake.vitaminA = 0;
            humanIntake.potassium = 0;
            humanIntake.totalFat = 0;
            humanIntake.sodium = 0;
        }
    }

    public void OnRayCastHitAction(ItemData itemData)
    {
        instructionPanel.SetActive(true);
        ShowItemInformationPanel(itemData);

        if (Input.GetKeyDown(KeyCode.E))
        {
            AddConsumeItem(itemData);
        }
    }

    public void OnNoRaycastHitAction()
    {
        instructionPanel.SetActive(false);
        itemInformationPanel.SetActive(false);
    }
}
