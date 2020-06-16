using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Cameras;

public class EnemyController : MonoBehaviour
{
    public static EnemyController instance;

    public  NavMeshAgent _agent;

    public Transform[] _direction;

   // public GameObject _weapon;

   // public Animation _anim;

    public Transform _wall;

    private int _damage;

  //  private float _attackTime;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _damage = MeleeWeaponContr.instance._damage;
        int i = Random.Range(0, 2);
        _agent.SetDestination(_direction[i].position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_wall);
       // _attackTime = MeleeWeaponContr.instance._attackTime;
       // _attackTime -= 1;

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerWall")
        {
            _agent.destination = transform.position;
            transform.rotation = _wall.rotation;

            Debug.Log("ATTACK");           
            WallHealth.instance.DamageWall(_damage);

           // _anim.Play();
          //  MeleeWeaponContr.instance._attackTime -= Time.deltaTime;

        }
    }
}
