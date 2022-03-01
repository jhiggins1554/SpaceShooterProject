using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.tag == "Bullet")
        {
            Score.points++;
            Destroy(gameObject);
        }

        if (hit.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
