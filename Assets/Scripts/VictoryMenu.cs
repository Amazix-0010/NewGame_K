using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public static VictoryMenu instance;

    public string _mainMenu;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(_mainMenu);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Vypínám hru");
    }
}
