using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public static Score instance;

    public float _scoreWin;
    private float _scoreCurrent;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        _scoreCurrent = 0;
        UIController.instance._score.text = "SCORE: " + _scoreCurrent + " / " + _scoreWin;
    }

    // Update is called once per frame
    void Update()
    {
        UIController.instance._score.text = "SCORE: " + _scoreCurrent + " / " + _scoreWin;
    }
}
