using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score;
    public Text Scores;
    public void addScore()
    {
        score++;
    }
    private void Update()
    {
        Scores.text = ""+score;

    }
}
