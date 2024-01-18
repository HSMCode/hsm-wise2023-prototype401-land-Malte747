using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterandFood : MonoBehaviour
{
    public float water = 100f; // Startwert des Wasserstands
    public float tree = 100f;
    public float waterDecreaseRate = 1f; // Multiplikator für die Verringerung des Wasserstands
    public float treeDecreaseRate = 1f;
    public Slider Food;
    public Slider Drink;
    public bool isTimerRunning = true;
    public GameObject Restart;

    void Start()
    {
        Food.value = tree;
        Drink.value = water;
        isTimerRunning = true;
    }

    void Update()
    {
        // Verringere den Wasserstand kontinuierlich basierend auf dem Multiplikator
        water -= Time.deltaTime * waterDecreaseRate;
        tree -= Time.deltaTime * treeDecreaseRate;
        Food.value = tree;
        Drink.value = water;
        // Überprüfe, ob der Wasserstand unter oder gleich 0 ist
        if (water <= 0f || tree <= 0f)
        {
            isTimerRunning = false;
            Destroy(gameObject);
            SetActiveObject(true);
        }
        if (water >= 100f)
        {
            water = 100f;
        }
        if (tree >= 100f)
        {
            tree = 100f;
        }
    }

    public void SetActiveObject(bool isActive)
    {
        Restart.SetActive(isActive);
    }

    public void MoreWater()
    {
        water += 10;
    }

    public void MoreTree()
    {
        tree += 10;
    }
}
