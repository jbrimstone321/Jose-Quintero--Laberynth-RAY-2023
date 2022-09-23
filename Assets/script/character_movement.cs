using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_movement : MonoBehaviour
{

    public float pMovementX;
    public float pMovementY;
    public float pMovementZ;

    public float pMovementSpeed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        pMovementX = - Input.GetAxis("Horizontal") * Time.deltaTime * pMovementSpeed;
        pMovementZ = - Input.GetAxis("Vertical") * Time.deltaTime * pMovementSpeed;

        transform.Translate(pMovementX, pMovementY, pMovementZ); 
    }
}