using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void ChangetoLevel()
    {
        SceneManager.LoadScene("L0-A");
    }
    public void ChangeToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ChangeToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void exitgame()
    {
        Application.Quit();
    }

}