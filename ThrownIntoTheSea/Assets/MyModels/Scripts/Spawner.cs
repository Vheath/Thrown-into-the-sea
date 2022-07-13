using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Bottle;
    public float spawnCooldown;
    public float startTime;
    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnCooldown);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         
    }
    
    void Spawn()
    {
        Instantiate(Bottle,SpawnPos.position, Quaternion.identity);
    }
}
