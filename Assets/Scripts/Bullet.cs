using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _bulletSpeed = 15;
    public Rigidbody theRB;
    public float _lifeTime = 2f;
    public int _damageAmount;

    public ParticleSystem _bulletPart;

    public bool _damageEnemy;
    public bool _damagePlayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = transform.forward * _bulletSpeed;

        _lifeTime -= Time.deltaTime;
        if (_lifeTime < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && _damageEnemy == true)
        {
            // Destroy(other.gameObject);

            other.gameObject.GetComponent<EnemyHealth>().DamageEnemy(_damageAmount);
        }

        /*if (other.gameObject.tag == "HeadShot" && _damageEnemy == true)
        {
            other.transform.parent.GetComponent<EnemyHealth>().DamageEnemy(_damageAmount * 5);
            Debug.Log("HEADSHOT");
        }*/


        /* if (other.gameObject.tag == "Player" && _damagePlayer == true)
         {
             PlayerHealth.instance.DamagePlayer(_damageAmount);
         }*/

        Instantiate(_bulletPart, transform.position + (transform.forward * (-_bulletSpeed * Time.deltaTime)), transform.rotation);
        Destroy(gameObject);
    }
}
