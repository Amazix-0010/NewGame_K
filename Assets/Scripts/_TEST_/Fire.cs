using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject _particleFire;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_particleFire, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
