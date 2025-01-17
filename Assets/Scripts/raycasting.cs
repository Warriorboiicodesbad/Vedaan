using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raycasting : MonoBehaviour
{
    public Transform cameraTr;
    public float maxDistance = 100f;
    public LayerMask layersToHit;
    public UnityEvent<ItemData> onRaycastHit;
    public UnityEvent onNoRaycastHit;

    private Ray ray;

    void Update()
    {
        ray = new Ray(cameraTr.position, cameraTr.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, layersToHit))
        {
            ItemScript data = hit.collider.gameObject.GetComponent<ItemScript>();
            onRaycastHit.Invoke(data.itemData);
        }
        else
        {
            onNoRaycastHit.Invoke();
        }

    }
}
