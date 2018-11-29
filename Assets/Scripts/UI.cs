using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour {

    public static UI instance;
    public TextMeshProUGUI equation;

    private void Awake()
    {
        instance = this;
    }

    public void SetEquation(string equation)
    {
        this.equation.text = equation;
    }

}
