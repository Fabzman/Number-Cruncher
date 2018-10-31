using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equationsgenerator : MonoBehaviour {

    public enum Difficulty { EASY, NORMAL, HARD}

    public Difficulty difficulty;
    public int numberOne;
    public int numberTwo;
    public int correctAnswer;

    public List <int> dummyAnswers;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.M))
            GenerateMultiplication();

        if (Input.GetKeyDown(KeyCode.A))
            GenerateAddition();

        if (Input.GetKeyDown(KeyCode.D))
            GenerateDivision();

        if (Input.GetKeyDown(KeyCode.R))
            GenerateRandom();
    }

    void GenerateMultiplication()
    {
        numberOne = Random.Range(1, 20);
        numberTwo = Random.Range(1, 20);
        correctAnswer = numberOne * numberTwo;

        GenerateDummyAnswers();

        Debug.Log(numberOne + "x" + numberTwo + "=" + correctAnswer);
    }

    void GenerateAddition()
    {
        numberOne = Random.Range(1, 20);
        numberTwo = Random.Range(1, 20);
        correctAnswer = numberOne + numberTwo;

        GenerateDummyAnswers();

        Debug.Log(numberOne + "+" + numberTwo + "=" + correctAnswer);
    }

    void GenerateSubtraction()
    {

    }

    void GenerateDivision()
    {
        numberOne = Random.Range(1, 20);
        numberTwo = Random.Range(1, 20);
        correctAnswer = numberOne / numberTwo;

        GenerateDummyAnswers();

        Debug.Log(numberOne + "/" + numberTwo + "=" + correctAnswer);
    }

    void GenerateDummyAnswers()
    {
        for (int i = 0; i < dummyAnswers.Count; i++)
        {
            int dummy;
            do
            {
                dummy = Random.Range(correctAnswer - 10, correctAnswer + 10);
            }
            while (dummy == correctAnswer || dummyAnswers.Contains(dummy));
            dummyAnswers[i] = dummy;
            Debug.Log("Dummy Answer:" + dummyAnswers[i]);
        }
    }

    void GenerateRandom()
    {
        int rnd = Random.Range(1, 5);
        if (rnd == 1)
            GenerateAddition();
        else if (rnd == 2)
            GenerateMultiplication();
        else
            GenerateMultiplication();
        //numberOne = Random.Range(1, 20);
        //numberTwo = Random.Range(1, 20);
        //correctAnswer = numberOne + numberTwo;

        //Debug.Log(numberOne + "+" + numberTwo + "=" + correctAnswer);
    }

    int GetRandomNumbers()
    {
        switch (difficulty)
        {
            case Difficulty.EASY:
                return (Random.Range(1, 10));
            case Difficulty.NORMAL:
                return (Random.Range(1, 20));
            case Difficulty.HARD:
                return (Random.Range(1, 100));
            default:
                return (Random.Range(1, 10));
        }
    }
}
