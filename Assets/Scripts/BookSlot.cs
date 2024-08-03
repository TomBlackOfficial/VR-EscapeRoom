using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BookSlot : MonoBehaviour
{
    public bool isUnlocked = false;
    public string tagToUnlock;

    [SerializeField] private UnityEvent onUnlock;

    public void Unlock()
    {
        onUnlock.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagToUnlock)
        {
            Unlock();
        }
    }
}
