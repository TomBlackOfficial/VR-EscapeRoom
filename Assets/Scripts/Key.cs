using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Key : MonoBehaviour
{
    private Rigidbody rb;
    private XRGrabInteractable interactable;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        interactable = GetComponent<XRGrabInteractable>();

        rb.isKinematic = true;
        interactable.enabled = false;
    }

    public void EnableKey()
    {
        rb.isKinematic = false;
        interactable.enabled = true;
    }
}
