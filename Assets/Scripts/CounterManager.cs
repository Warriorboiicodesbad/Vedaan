using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] CartManager cartManager;
    [SerializeField] Button buyButton;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Checkout"))
        {
            GameData.isCheckingOut = true;
            playerManager.userConsumptionCG.alpha = 1;

            buyButton.gameObject.SetActive(true);
            if(playerManager.CheckCanConsumeItems())
            {
                buyButton.interactable = true;
            }
            else
            {
                buyButton.interactable = false;
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

            buyButton.gameObject.SetActive(false);
            InstructionsManager.Instance.RemoveInstruction(GameData.intakeNotCompletedInstruction);
        }
    }

    public void BuyCart()
    {
        GameData.isCheckingOut = false;
        playerManager.userConsumptionCG.alpha = 0;
        playerManager.ConsumeItems();
        SceneManager.LoadScene("CompletedIntake");
    }
}
