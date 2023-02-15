using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class Scoring : MonoBehaviour
{
    public static Scoring instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    int score = 0;
    int highScore = 0;

    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        scoreText.text = "Score: " + score.ToString();
        highScoreText.text = " High Score: " + highScore.ToString();
    }

    public void AddPoint()
    {
        score += 100;
        scoreText.text = "Score: " + score.ToString();

        if(highScore < score)
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }
}