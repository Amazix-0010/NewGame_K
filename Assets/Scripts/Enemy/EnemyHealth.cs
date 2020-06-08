using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int _healthEnemy;

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
            Destroy(gameObject);
        }
    }
}
