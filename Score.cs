using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public static float points = 0;

    public void Update()
    {
        score.text = "" + points;
    }
}
