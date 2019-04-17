using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectByXPosition : MonoBehaviour
{
    [SerializeField] GameObject spinningRoot;
    [SerializeField] float mapLength = 0;

    private void Start()
    {
        mapLength = GetComponent<ScreenClipRight>().getMapLength();
    }

    void Update()
    {
        if (mapLength < 2)
        {
            mapLength = GetComponent<ScreenClipRight>().getMapLength();
        }
        float distance = transform.position.x;
        float rotation = (distance / mapLength) * 360;
        spinningRoot.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, rotation));   
    }
}
