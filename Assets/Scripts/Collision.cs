using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    WaterandFood waterandfood;


    void Start()
    {
        waterandfood = GetComponent<WaterandFood>();
    }
    private void OnTriggerEnter(Collider other)
    {
        // Überprüfe, ob der Trigger das Tag "Water" hat
        if (other.CompareTag("Water"))
        {
            // Zerstöre das "Water"-Objekt
            Destroy(other.gameObject);
            waterandfood.MoreWater();
        }
        else if (other.CompareTag("Tree"))
        {
            // Zerstöre das "Water"-Objekt
            Destroy(other.gameObject);
            waterandfood.MoreTree();
        }
    }
}
