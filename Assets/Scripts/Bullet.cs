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
    // public bool _damagePlayer;

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
        Instantiate(_bulletPart, transform.position + (transform.forward * (-_bulletSpeed * Time.deltaTime)), transform.rotation);
        Destroy(gameObject);
    }
}
