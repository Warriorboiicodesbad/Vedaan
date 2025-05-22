using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] CartManager cartManager;
    [SerializeField] TMP_Text buyText;
    [SerializeField] GameObject buyBG;

    private bool isCompleted = false;


    private void Update()
    {
        if (isCompleted && Input.GetKeyDown(KeyCode.Space))
        {
            BuyCart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Checkout"))
        {
            GameData.isCheckingOut = true;
            playerManager.userConsumptionCG.alpha = 1;

            buyBG.gameObject.SetActive(true);
            if(playerManager.CheckCanConsumeItems())
            {
                isCompleted = true; 
                buyText.text = "Press Space to buy cart.";
            }
            else
            {
                isCompleted = false;
                buyText.text = GameData.intakeNotCompletedInstruction;
                InstructionsManager.Instance.AddInstruction(GameData.intakeNotCompletedInstruction);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Checkout"))
        {
            GameData.isCheckingOut = false;
            playerManager.userConsumptionCG.alpha = 0;

            buyBG.gameObject.SetActive(false);
            InstructionsManager.Instance.RemoveInstruction(GameData.intakeNotCompletedInstruction);
        }
    }

    public void BuyCart()
    {
        GameData.isCheckingOut = false;
        GameData.isCartEquiped = false;
        playerManager.userConsumptionCG.alpha = 0;
        playerManager.ConsumeItems();
        SceneManager.LoadScene("CompletedIntake");
    }
}
