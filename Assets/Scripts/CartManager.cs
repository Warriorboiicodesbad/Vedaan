using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CartManager : MonoBehaviour
{
    [SerializeField] GameObject cartItemPrefab, cartPanel;
    [SerializeField] Transform cartItemParentTr;
    [SerializeField] PlayerController playerController;
    [SerializeField] PlayerManager playerManager;

    private Dictionary<ItemData, CartItem> itemsCountDictionary = new Dictionary<ItemData, CartItem>();
    private CartItem cartItem;
    private bool addedAddToCartInstruction = false;

    private void Start()
    {
        InstructionsManager.Instance.AddInstruction(GameData.toggleCartInstruction);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cartPanel.SetActive(!cartPanel.activeInHierarchy);
            playerController.enabled = !cartPanel.activeInHierarchy;
            Cursor.lockState = cartPanel.activeInHierarchy ? CursorLockMode.None : CursorLockMode.Locked;
        }
    }

    public void BuyCart()
    {
        foreach(var item in itemsCountDictionary)
        {

        }
    }

    public void AddToCart(ItemData itemData)
    {
        if(itemsCountDictionary.ContainsKey(itemData))
        {
            itemsCountDictionary[itemData].Increase();
        }
        else
        {
            GameObject cartItemObj = Instantiate(cartItemPrefab, cartItemParentTr);

            cartItem = cartItemObj.GetComponent<CartItem>();
            itemsCountDictionary.Add(itemData, cartItem);

            cartItem.itemData = itemData;
            cartItem.itemNameTxt.text = itemData.name;
            cartItem.itemImage.sprite = itemData.Image;
            cartItem.Increase();
        }
    }

    public void OnRayCastHitAction(ItemData itemData)
    {
        if (!addedAddToCartInstruction)
        {
            addedAddToCartInstruction = true;
            InstructionsManager.Instance.AddInstruction(GameData.addToCartInstruction);
            InstructionsManager.Instance.AddInstruction(GameData.openItemInfoPanelInstruction);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (playerManager.itemInformationPanel.activeInHierarchy)
            {
                playerManager.itemInformationPanel.SetActive(false);
            }
            else
            {
                playerManager.ShowItemInformationPanel(itemData);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(GameData.isCartEquiped)
            {
                AddToCart(itemData);

                string currItemInstruction = $"Added {itemData.name} to cart";
                InstructionsManager.Instance.AddInstruction(currItemInstruction);
                StartCoroutine(RemoveInstruction(currItemInstruction));
            }
            else
            {
                InstructionsManager.Instance.AddInstruction(GameData.equipCartToAddItem);
                StartCoroutine(RemoveInstruction(GameData.equipCartToAddItem));
            }
        }
    }

    public void OnNoRaycastHitAction()
    {
        if (addedAddToCartInstruction)
        {
            addedAddToCartInstruction = false;
            InstructionsManager.Instance.RemoveInstruction(GameData.addToCartInstruction);
            InstructionsManager.Instance.RemoveInstruction(GameData.openItemInfoPanelInstruction);

            playerManager.itemInformationPanel.SetActive(false);
        }
    }

    public IEnumerator RemoveInstruction(string instruction)
    {
        yield return new WaitForSeconds(3f);
        InstructionsManager.Instance.RemoveInstruction(instruction);
    }
}
