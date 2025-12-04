using System;
using UnityEngine;

public class InteractableChecker : MonoBehaviour
{
    Interactable curInteractable;

    private void FixedUpdate()
    {
        RaycastHit hit;
        Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit,
            2,LayerMask.GetMask("Interactable"));
        if (hit.collider != null)
        {
            curInteractable = hit.collider.GetComponent<Interactable>();
            curInteractable.Select();
        }
        else
        {
            curInteractable?.Unselect();
            curInteractable = null;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && curInteractable)
        {
            curInteractable.Active();
        }
            
    }
}
