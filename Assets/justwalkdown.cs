using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justwalkdown : MonoBehaviour
{
    [SerializeField] float walkSpeed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = newPosition.y - (Time.deltaTime * walkSpeed);
        transform.position = newPosition;
    }
}
