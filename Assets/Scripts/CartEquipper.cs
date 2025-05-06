using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CartEquipper : MonoBehaviour
{
    [SerializeField] GameObject cartObject;
    [SerializeField] Transform cameraTr, cartPositionTr;

    private Vector3 initialOffset;
    private bool canEquip = false;

    void Start()
    {
        // Store initial local offset from the camera to the cart
        initialOffset = cartPositionTr.position - cameraTr.position;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (canEquip && !GameData.isCartEquiped) EquipCart();
        }
    }

    void LateUpdate()
    {
        UpdateCartPosition();
    }

    void UpdateCartPosition()
    {
        // Get the Y rotation of the camera only
        Vector3 cameraEuler = cameraTr.eulerAngles;
        Quaternion cartRotation = Quaternion.Euler(0f, cameraEuler.y, 0f);

        // Position the cart in front of the camera using initial offset rotated by Y
        Vector3 rotatedOffset = cartRotation * initialOffset;
        cartPositionTr.position = cameraTr.position + rotatedOffset;

        // Apply only Y rotation to the cart
        cartPositionTr.rotation = cartRotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!GameData.isCartEquiped)
        {
            if (other.gameObject.CompareTag("Cart"))
            {
                canEquip = true;
                InstructionsManager.Instance.AddInstruction(GameData.cartEquipText);
            }
        }
        else
        {
            InstructionsManager.Instance.AddInstruction(GameData.cartAlreadyEquipedText);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(!GameData.isCartEquiped)
        {
            if (other.gameObject.CompareTag("Cart"))
            {
                canEquip = false;
            }
        }
        else
        {

        }

        InstructionsManager.Instance.RemoveInstruction(GameData.cartEquipText);
        InstructionsManager.Instance.RemoveInstruction(GameData.cartAlreadyEquipedText);
    }

    private void EquipCart()
    {
        InstructionsManager.Instance.RemoveInstruction(GameData.cartEquipText);
        InstructionsManager.Instance.AddInstruction(GameData.cartAlreadyEquipedText);
        cartObject.SetActive(true); // or Instantiate if needed
        GameData.isCartEquiped = true;
    }
}
