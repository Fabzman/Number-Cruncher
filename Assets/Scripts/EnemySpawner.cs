using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public static EnemySpawner instance;

    public int enemyCount;
    public float spawnTimer;
    public GameObject enemy;
    public Transform enemySpawner;
    private Transform currentEnemy;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start ()
    {
        spawnTimer = 3f;
        enemyCount = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0 && !currentEnemy)
        {
            currentEnemy = Instantiate(enemy, transform.position, transform.rotation).transform;
            enemyCount++;
            spawnTimer = 10f;
        }
	}
}
