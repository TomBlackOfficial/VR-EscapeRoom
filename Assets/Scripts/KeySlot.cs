using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeySlot : MonoBehaviour
{
    public bool isUnlocked = false;
    public Text text;

    public void Unlock()
    {
        isUnlocked = true;
        text.text = "Press the button...";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            Unlock();
            Destroy(other.gameObject);
        }
    }
}
