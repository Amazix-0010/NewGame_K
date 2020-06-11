using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallHealth : MonoBehaviour
{
    public static WallHealth instance;

    public float _wallHealth;
    private float _wallCurrent;



    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _wallCurrent = _wallHealth;
        UIController.instance._wallHealth.text = "WALL HEALTH: " + _wallCurrent + " / " + _wallHealth;
    }

    // Update is called once per frame
    void Update()
    {
        UIController.instance._wallHealth.text = "WALL HEALTH: " + _wallCurrent + " / " + _wallHealth;
    }

    public void DamageWall(int _damageAmount)
    {
        Debug.Log("ZEĎ ZTRACI ZIVOTY" + _damageAmount);

        _wallCurrent -= _damageAmount;


        if (_wallCurrent <= 0)
        {
            Destroy(gameObject);
            GameManager.instance.PlayerDied();
        }
    }
}
