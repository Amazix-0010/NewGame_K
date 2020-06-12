﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public string _loseMenu;

    public string _winMenu1;


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

    public void PlayerDied()
    {       
        SceneManager.LoadScene(_loseMenu);
        Debug.Log("LOSE MENU APPEAR");
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayerWin()
    {
        SceneManager.LoadScene(_winMenu1);
        Debug.Log("WIN MENU APPEAR");
    }
}
