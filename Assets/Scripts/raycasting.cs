using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class raycasting : MonoBehaviour
{
    public GameObject instructionPanel, informationPanel;
    Ray ray;
    public float maxDistance = 100f;
    public LayerMask layersToHit;
    public UnityEvent<ScriptableObjecte>  onPressedE, onShowPanel;
    
    
    

       
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();

    }
    void CheckForColliders()
    {
        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, layersToHit)) 
        {
            instructionPanel.SetActive(true);
            ItemScript data = hit.collider.gameObject.GetComponent<ItemScript>();
            onShowPanel.Invoke(data.itemData);
              
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                onPressedE.Invoke(data.itemData);
            }

        }
        else
        {
            instructionPanel.SetActive(false);
            informationPanel.SetActive(false);
        }
    }
}
