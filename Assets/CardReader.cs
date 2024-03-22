using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CardReader : XRSocketInteractor
{
    [SerializeField] private GameObject bar;
    private Transform cardTransform;
    private Vector3 hoverEntry;
    private bool isSwiping;
    
    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        cardTransform = args.interactableObject.transform;
        hoverEntry = cardTransform.position;
        Debug.Log(cardTransform.position);
        isSwiping = true;
    }
    
    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        var traveledDistance = args.interactableObject.transform.position - hoverEntry;
        Debug.Log(traveledDistance);
        if ((traveledDistance.y > 0.3 || traveledDistance.y < -0.3) && isSwiping)
        {
            isSwiping = false;
            bar.gameObject.SetActive(false);
        }

        cardTransform = null;
    }
    
    private void Update()
    {
        if (cardTransform != null)
        {
            Vector3 keycardUp = cardTransform.forward;
            float dot = Vector3.Dot(keycardUp, Vector3.up);
            

            if (Math.Abs(dot) < 0.95f)
            {
                Debug.Log("dot: " + dot);
                isSwiping = false;
            }
        }
    }
    
    
    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return false;
    }

}
