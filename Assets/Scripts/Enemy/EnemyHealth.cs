using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static EnemyHealth instance;

    public int _healthEnemy;
    public int _scoreEnemy;

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

    public void DamageEnemy(int _damageAmount)
    {
        _healthEnemy -= _damageAmount;

        if (_healthEnemy <= 0)
        {
            PlayerController.instance._scorePlayer += _scoreEnemy;
            Destroy(gameObject);
            Debug.Log("SCORE + " + _scoreEnemy);
        }
    }
}
