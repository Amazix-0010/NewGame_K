using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string _level_1;

    public void StartGame()
    {
        SceneManager.LoadScene(_level_1);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Vypínám hru");
    }

}
