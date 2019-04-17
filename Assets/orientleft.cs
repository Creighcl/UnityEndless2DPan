using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientleft : MonoBehaviour
{
    [SerializeField] GameObject leftClipMarker;
    [SerializeField] float differenceX = 0;
    [SerializeField] Camera leftTrailCamera;
    void Start()
    {
        float boundaryX = Camera.main.ViewportToWorldPoint(new Vector2(0,0)).x;
        Vector3 newPosition = leftClipMarker.transform.position;
        newPosition.x = boundaryX;
        leftClipMarker.transform.position = newPosition;
        differenceX = boundaryX;
    }

    public float GetDifferenceX()
    {
        return differenceX;
    }

    void Update()
    {
        
    }
}
