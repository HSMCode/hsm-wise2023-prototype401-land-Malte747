using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour

{
    public TextMeshProUGUI timerText; // TMP-Textobjekt zur Anzeige der Spielzeit
    private float elapsedTime = 0f; // Verstrichene Zeit
    public WaterandFood waterandfood;

    void Start()
    {
        waterandfood = GameObject.Find("Elephant").GetComponent<WaterandFood>();
    }
    void Update()
    {
        if (waterandfood.isTimerRunning)
        {
            Debug.Log("111");
        elapsedTime += Time.deltaTime;
        int timeInSeconds = Mathf.RoundToInt(elapsedTime);

        UpdateTimerDisplay(timeInSeconds);
        }
    }

    void UpdateTimerDisplay(int timeInSeconds)
    {
        if (timerText != null)
        {
            int minutes = timeInSeconds / 60;
            int seconds = timeInSeconds % 60;

            timerText.text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
        }
    }
}

