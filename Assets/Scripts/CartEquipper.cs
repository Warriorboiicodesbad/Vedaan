using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CartEquipper : MonoBehaviour
{
    [SerializeField] GameObject cartObject;
    [SerializeField] Transform cameraTr, cartPositionTr;
    [SerializeField] TMP_Text cartText;

    private Vector3 initialOffset;
    private bool canEquip = false, isEquiped = false;

    void Start()
    {
        // Store initial local offset from the camera to the cart
        initialOffset = cartPositionTr.position - cameraTr.position;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (canEquip) EquipCart();
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
        if(!isEquiped)
        {
            if (other.gameObject.CompareTag("Cart"))
            {
                canEquip = true;
                cartText.text = "Press E to Equip Cart";
                cartText.transform.parent.gameObject.SetActive(true);
            }
        }
        else
        {
            cartText.text = "Cart already Equiped";
            cartText.transform.parent.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(!isEquiped)
        {
            if (other.gameObject.CompareTag("Cart"))
            {
                canEquip = false;
                cartText.transform.parent.gameObject.SetActive(false);
            }
        }
        else
        {
            cartText.transform.parent.gameObject.SetActive(false);
        }
    }

    private void EquipCart()
    {
        cartObject.SetActive(true); // or Instantiate if needed
        isEquiped = true;
        cartText.transform.parent.gameObject.SetActive(false);
    }
}
