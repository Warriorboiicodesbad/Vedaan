using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartManager : MonoBehaviour
{
    [SerializeField] GameObject cartItemPrefab;
    [SerializeField] Transform cartItemParentTr;
    [SerializeField] GameObject addToCartInstructionPanel;

    private Dictionary<ItemData, CartItem> itemsCountDictionary = new Dictionary<ItemData, CartItem>();
    private CartItem cartItem;

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
        if(!addToCartInstructionPanel.activeInHierarchy) addToCartInstructionPanel.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E))
        {
            AddToCart(itemData);
        }
    }

    public void OnNoRaycastHitAction()
    {
        if (addToCartInstructionPanel.activeInHierarchy) addToCartInstructionPanel.SetActive(false);
    }
}
