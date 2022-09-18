using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public string start;
    public GameObject optionsPanel;
    public void StartGame()
    {
        SceneManager.LoadScene(start);
    }

    public void QuitGame()
    {
        // Editor Unity
        //UnityEditor.EditorApplication.isPlaying = false;
        // Jogo Compilado
        Application.Quit();
    }

    public void ShowOptions()
    {
        optionsPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        optionsPanel.SetActive(false);
    }
}
