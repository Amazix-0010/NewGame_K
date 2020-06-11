using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public Transform _firingPoint;
    public GameObject _bulletPrefab;
    public GameObject _gun;

    public Transform _camTrans;

    public int _scorePlayer;

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
        if (Input.GetMouseButtonDown(0) && Gun.instance.fireCounter <= 0)
        {

            RaycastHit hit;
            if (Physics.Raycast(_camTrans.position, _camTrans.forward, out hit, 50f))
            {
                if (Vector3.Distance(_camTrans.position, hit.point) > 2f)
                {
                    _firingPoint.LookAt(hit.point);
                }
            }
            else
            {
                _firingPoint.LookAt(_camTrans.position + (_camTrans.forward * 45f));
            }
            FireShot();
        }       
    }
    public void FireShot()
    {
        Instantiate(_bulletPrefab, _firingPoint.position, _firingPoint.rotation);
        Gun.instance.fireCounter = Gun.instance.fireRate;
    }
}
