using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephantMovement : MonoBehaviour

{
    public float movementSpeed = 5f;
    public float rotationSpeed = 50f;
    

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Der Spieler hält die Leertaste gedrückt
            
            movementSpeed = 0f;
            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
        else
        {
            // Der Spieler hat die Leertaste losgelassen
            
            movementSpeed = 5f;
            float automaticMovement = movementSpeed * Time.deltaTime;
            transform.Translate(0f, 0f, automaticMovement);
        }
    }
}