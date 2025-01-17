using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    public float mouseSensitivity = 100f; 
    public Transform playerBody; 

    private float xRotation = 0f;
    private float yRotation = 0f;

    void Start()
    {   
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

       
        yRotation += mouseX; // Horizontal rotation
        xRotation -= mouseY; // Vertical rotation

        
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}