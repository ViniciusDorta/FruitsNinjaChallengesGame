using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoints : MonoBehaviour
{
    public static ScorePoints instance;
    public int Score;
    public Text scoreText;
    void Start()
    {
        Score = 0;
        instance = this;
    }

    void Update()
    {
        scoreText.text = Score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Score") == true)
        {
            Score = Score + 1;
        }

    }
}
