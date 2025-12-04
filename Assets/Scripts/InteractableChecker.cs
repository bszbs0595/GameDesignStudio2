using System;
using UnityEngine;

public class InteractableChecker : MonoBehaviour
{
    Interactable curInteractable;
    public float checkDistance;

    private void FixedUpdate()
    {
        RaycastHit hit;
        Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit,
            checkDistance,LayerMask.GetMask("Interactable"));
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
        if (Input.GetMouseButtonDown(0) && curInteractable)
        {
            curInteractable.Active();
        }
            
    }
}
