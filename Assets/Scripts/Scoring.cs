using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    public Text ScoreText;
    static int score = 0;

    public void UpdateScore()
    {
        score++;
        ScoreText.text = "Score: " + score;
    }

    public void UpdateScore(int newScore)
    {
        score = newScore;
        ScoreText.text = "Score: " + score;
    }

}
