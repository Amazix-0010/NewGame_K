using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public static WinMenu instance;
    public string _nextLevel2;

    private void Awake()
    {
        instance = this;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Start()
    {
        
    }

    public void NextRound()
    {
        SceneManager.LoadScene(_nextLevel2);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Vypínám hru");
    }
}
