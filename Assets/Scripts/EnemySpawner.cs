using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public static EnemySpawner instance;

    public int enemyCount;
    public float spawnTimer;
    public GameObject enemy;
    public Transform enemySpawner;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start ()
    {
        spawnTimer = 5f;
        enemyCount = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        spawnTimer -= Time.deltaTime;

        if (enemyCount >= 1)
        {
            return;
        }

        if (spawnTimer <= 0 && enemyCount <1)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            enemyCount++;
            spawnTimer = 10f;
        }
	}
}
