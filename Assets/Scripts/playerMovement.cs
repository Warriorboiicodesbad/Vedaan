using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
 
   
    
   
   
    public float speed = 12f;
    public float mouseSensitivity = 100f;
    

    private float xRotation = 0f;
    
    public CinemachineVirtualCamera virtualcamera;

    void Start()
    {
        


        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        

        
        transform.Translate(x * Time.deltaTime * speed, 0, z * Time.deltaTime * speed, Space.Self);


        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        virtualcamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        transform.Rotate(Vector3.up * mouseX);




    }
    
}
