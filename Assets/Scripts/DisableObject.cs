using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisableObject : MonoBehaviour
{
    public GameObject objectToDisable;
    public KeySlot keySlot;

    public UnityEvent doorOpened;

    public void DisableTheObject()
    {
        if (keySlot == null)
        {
            objectToDisable.SetActive(false);
            doorOpened.Invoke();
        }
        else
        {
            if (keySlot.isUnlocked)
            {
                objectToDisable.SetActive(false);
                doorOpened.Invoke();
            }
        }
    }
}
