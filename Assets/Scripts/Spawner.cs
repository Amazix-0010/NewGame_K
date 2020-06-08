using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectPrefab;                // The prefab to be spawned.
    public float spawnTime = 6f;            // How long between each spawn.
    private Vector3 spawnPosition;

    // Use this for initialization
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);

    }

    void Spawn()
    {
        spawnPosition.x = Random.Range(-10, 10);
        spawnPosition.y = 1f;
        spawnPosition.z = Random.Range(117, 118);

        Instantiate(objectPrefab[UnityEngine.Random.Range(0, objectPrefab.Length - 0)], spawnPosition, Quaternion.identity);
    }
}
