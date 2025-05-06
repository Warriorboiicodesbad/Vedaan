using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CartItem : MonoBehaviour
{
    public TMP_Text itemNameTxt, quantityText;
    public Image itemImage;
    public Button decreaseButton, cartItemButton;
    [HideInInspector] public ItemData itemData;

    private int quantity = 0;

    public void Increase()
    {
        if (quantity == 0) gameObject.SetActive(true);

        quantity++;
        quantityText.text = quantity.ToString();
    }

    public void Decrease()
    {
        if (quantity == 0) return;

        quantity = Mathf.Max(quantity-1, 0);
        quantityText.text = quantity.ToString();

        if (quantity == 0) gameObject.SetActive(false);
    }
}
