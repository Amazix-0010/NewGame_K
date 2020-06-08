using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponContr : MonoBehaviour
{
    public static MeleeWeaponContr instance;

    public float _attackTime = 4f;

    public int _damage;

    public float _waitTimer = 4f;

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


}
