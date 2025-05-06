using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterManager : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] CartManager cartManager;
    [SerializeField] GameObject buyButton;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Checkout"))
        {
            playerManager.userConsumptionCG.alpha = 1;
            cartManager.cartPanel.SetActive(true);
            buyButton.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Checkout"))
        {
            playerManager.userConsumptionCG.alpha = 0;
            cartManager.cartPanel.SetActive(false);
            buyButton.SetActive(false);
        }
    }

    public void BuyCart()
    {
        playerManager.userConsumptionCG.alpha = 0;
        cartManager.cartPanel.SetActive(false);
        buyButton.SetActive(false);
    }
}
