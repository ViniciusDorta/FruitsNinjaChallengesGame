using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOver;
    public GameObject nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void ShowNextLevel()
    {
        if (ScorePoints.instance.Score >= 10)
        {
            nextLevel.SetActive(true);
        }
    }

    public void NextGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}
