using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseMenu : MonoBehaviour
{
    public static LoseMenu instance;

    public string _level_1;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void ResetRound()
    {

    }

    public void ResetGame()
    {
        SceneManager.LoadScene(_level_1);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Vypínám hru");
    }
}
