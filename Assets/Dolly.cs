using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolly : MonoBehaviour
{
    [SerializeField] float panSpeed = 1f;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Vector3 newPosition = transform.position;
            newPosition.x = newPosition.x += (Input.GetAxis("Horizontal") * Time.deltaTime * panSpeed);
            transform.position = newPosition;
        }
    }
}
