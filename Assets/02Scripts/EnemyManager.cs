using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] EnemyObjs;
    public Transform[] spawnPoint;

    public float maxSpawnDelay;
    public float curSpawnDelay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        curSpawnDelay += Time.deltaTime;

        if (curSpawnDelay > maxSpawnDelay)
        {
            SpawnEnemy();
            maxSpawnDelay = Random.Range(0.5f, 0.55f);
            curSpawnDelay = 0;
        }
    }

    void SpawnEnemy()
    {
        //소환될 적
        int ranEnemy = Random.Range(0, 4);
        //소환될 위치
        int ranPoint = Random.Range(0, 4);
        Instantiate(EnemyObjs[ranEnemy], transform.position, Quaternion.identity);
    }
}