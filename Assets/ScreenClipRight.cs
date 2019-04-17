using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenClipRight : MonoBehaviour
{
    [SerializeField] Transform RightClipMarker;
    [SerializeField] Transform LeftClipMarker;
    [SerializeField] Camera primaryCam;
    [SerializeField] Camera trailCam;
    [SerializeField] float mapLength = 1f;

    private void Start()
    {
        mapLength = Vector2.Distance(LeftClipMarker.transform.position, RightClipMarker.transform.position);
    }
    void Update()
    {
        Vector3 newTrailCamPosition = trailCam.transform.localPosition;
        newTrailCamPosition.x = transform.position.x < 1 ? mapLength : -mapLength;
        trailCam.transform.localPosition = newTrailCamPosition;

        float rightClipViewportPosition = Camera.main.WorldToViewportPoint(RightClipMarker.position).x;
        if (rightClipViewportPosition < 0) transform.position = new Vector3(-rightClipViewportPosition, transform.position.y, transform.position.z);

        float leftClipViewportPosition = Camera.main.WorldToViewportPoint(LeftClipMarker.position).x;

        float screenResolutionOffset = LeftClipMarker.GetComponent<orientleft>().GetDifferenceX();
        float rightmostCameraPositionX = mapLength - (2 * Mathf.Abs(screenResolutionOffset));
        if (leftClipViewportPosition > 1) transform.position = new Vector3(rightmostCameraPositionX, transform.position.y, transform.position.z);
    }

    public float getMapLength()
    {
        return mapLength;
    }
}
