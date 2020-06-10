using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;
    // Start is called before the first frame update

  /*  public void Continue()
    {

    }*/

    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Vypínám hru");
    }

}
