using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    //private PlayerController _player;
    public float enemySpeed = 1f;
    public Transform player;
    public bool enemySlow;


    // Use this for initialization
    void Start ()
    {
        //_player = GameObject.Find("Player").GetComponent<PlayerController>();
        player = GameObject.Find("Player").transform;
        enemySlow = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        float step = enemySpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);

        if (enemySlow == true)
        {
            enemySpeed = enemySpeed = 0.5f;
        }

        else if (enemySlow == false)
        {
            enemySpeed = enemySpeed = 1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enemySlow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enemySlow = false;
        }
        //if (other.tag == "Fist")
        //{
        //    Destroy(gameObject);
        //    EnemySpawner.instance.enemyCount--;
        //}
    } 
}
