using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothing;
    private Vector3 startPos;
    private Vector3 destinationPos;
    private bool move;

    private void Awake()
    {
        startPos = transform.localPosition;
        destinationPos = startPos + offset;
    }

    private void Update()
    {
        if (move && transform.localPosition != destinationPos)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, destinationPos, Time.deltaTime * smoothing);
        }
    }

    public void MoveToDestination()
    {
        move = true;
    }
}
