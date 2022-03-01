using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SpaceShooter");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
