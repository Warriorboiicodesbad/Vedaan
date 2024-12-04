using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class raycasting : MonoBehaviour
{

    Ray ray;
    public float maxDistance = 100f;
    public LayerMask layersToHit;
    public UnityEvent<ScriptableObject> onPressedI, onPressedE;

       
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
            ItemScript data = hit.collider.gameObject.GetComponent<ItemScript>();
            if (Input.GetKeyDown(KeyCode.I))
            {
                onPressedI.Invoke(data.itemData);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                onPressedE.Invoke(data.itemData);
            }

        }
    }
}
