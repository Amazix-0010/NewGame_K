using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BomberManContr : MonoBehaviour
{
    public static BomberManContr instance;

    public NavMeshAgent _agent;

    public Transform[] _direction;

    public Transform _wall;

    public int _damage;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        int i = Random.Range(0, 2);
        _agent.SetDestination(_direction[i].position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_wall);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerWall")
        {
            Debug.Log("BOOM");
            WallHealth.instance.DamageWall(_damage);
            AudioManager.instance.PlaySFX(0);
            Destroy(gameObject);
        }
    }
}
