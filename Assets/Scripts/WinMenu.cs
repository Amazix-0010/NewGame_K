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
    }

    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
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
