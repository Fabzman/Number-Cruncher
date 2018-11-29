using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour {

    public static UI instance;
    public TextMeshProUGUI equation;
    public TextMeshProUGUI currentNumber;

    private void Awake()
    {
        instance = this;
    }

    public void SetEquation(string equation)
    {
        this.equation.text = equation;
    }

    public void SetCurrentNumber(string number)
    {
        currentNumber.text = "Current Number: " + number;
    }
}
