using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Das zu verfolgende GameObject
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Der Abstand zwischen der Kamera und dem GameObject

    void Update()
    {
        if (target != null)
        {
            // Aktualisiere die Position der Kamera basierend auf der Position des zu verfolgenden GameObjects
            transform.position = target.position + offset;
        }
    }
}
