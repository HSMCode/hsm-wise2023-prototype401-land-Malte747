using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour

{
    void Update()
    {
        // Beispiel: Drücke die R-Taste, um die Szene neu zu starten
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RestartScene();
        }
    }

    public void RestartScene()
    {
        // Lade die aktuelle Szene erneut
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}

