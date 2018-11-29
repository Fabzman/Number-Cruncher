using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyController : MonoBehaviour {

    public enum Difficulty { EASY, MEDIUM, HARD }

    public Difficulty difficulty;

    //private PlayerController _player;
    public float enemySpeed = 1f;
    public Transform player;
    public bool enemySlow;

    public int correctAnswer;

    public Vector3 offsetFromPlayer;
    public float getToPlayer;



    // Use this for initialization
    void Start ()
    {
        //_player = GameObject.Find("Player").GetComponent<PlayerController>();
        GenerateRandomEquation();
        player = GameObject.Find("Player").transform;
        enemySlow = false;
        transform.DOMove(player.transform.position + offsetFromPlayer, getToPlayer).SetEase(Ease.OutQuad);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //float step = enemySpeed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, player.position, step);

        //if (enemySlow == true)
        //{
        //    enemySpeed = enemySpeed = 0.5f;
        //}

        //else if (enemySlow == false)
        //{
        //    enemySpeed = enemySpeed = 1f;
        //}
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

    void GenerateRandomEquation()
    {
        int rnd = Random.Range(1, 100);
        if (rnd <= 35)
            GenerateAddition();
        else if (rnd <= 60)
            GenerateSubtraction();
        else if (rnd <= 90)
            GenerateMultiplication();
        else
            GenerateDivision();
    }

    void GenerateMultiplication()
    {
        int numberOne = GetRandomNumbers();
        int numberTwo = GetRandomNumbers();
        correctAnswer = numberOne * numberTwo;

        UI.instance.SetEquation(numberOne + " * " + numberTwo);
    }

    void GenerateAddition()
    {
        int numberOne = GetRandomNumbers();
        int numberTwo = GetRandomNumbers();
        correctAnswer = numberOne + numberTwo;

        UI.instance.SetEquation(numberOne + " + " + numberTwo);
    }

    void GenerateSubtraction()
    {
        int numberOne = GetRandomNumbers();
        int numberTwo = GetRandomNumbers();
        correctAnswer = numberOne - numberTwo;

        UI.instance.SetEquation(numberOne + " - " + numberTwo);
    }

    void GenerateDivision()
    {
        int numberOne = GetRandomNumbers();
        int numberTwo = GetRandomNumbers();
        correctAnswer = numberOne / numberTwo;

        UI.instance.SetEquation(numberOne + " / " + numberTwo);
    }

    /// <summary>
    /// Gets a random number based on our difficulty
    /// </summary>
    /// <returns>A random number</returns>
    int GetRandomNumbers()
    {
        switch (difficulty)
        {
            case Difficulty.EASY:
                return (Random.Range(1, 10));
            case Difficulty.MEDIUM:
                return (Random.Range(1, 20));
            case Difficulty.HARD:
                return (Random.Range(1, 100));
            default:
                return (Random.Range(1, 10));
        }
    }
}
