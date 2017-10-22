using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    public float currentNumber = 0;
    public float previousNumber = 0;
    public string operation;
    Text txtNumbers;
    public GameObject force;

    void Start()
    {
        txtNumbers = GameObject.Find("TxtNumber").GetComponent<Text>();
    }

    public void ClickOne()
    {
        currentNumber = currentNumber * 10 + 1;
        resetMonitor();
    }

    public void ClickTwo()
    {
        currentNumber = currentNumber * 10 + 2;
        resetMonitor();
    }

    public void ClickThird()
    {
        currentNumber = currentNumber * 10 + 3;
        resetMonitor();
    }
    public void ClickFour()
    {
        currentNumber = currentNumber * 10 + 4;
        resetMonitor();
    }
    public void ClickFive()
    {
        currentNumber = currentNumber * 10 + 5;
        resetMonitor();
    }
    public void ClickSix()
    {
        currentNumber = currentNumber * 10 + 6;
        resetMonitor();
    }
    public void ClickSeven()
    {
        currentNumber = currentNumber * 10 + 7;
        resetMonitor();
    }
    public void ClickEight()
    {
        currentNumber = currentNumber * 10 + 8;
        resetMonitor();
    }
    public void ClickNine()
    {
        currentNumber = currentNumber * 10 + 9;
        resetMonitor();
    }
    public void ClickZero()
    {
        currentNumber = currentNumber * 10 + 0;
        resetMonitor();
    }

    public void ClickPlus()
    {
        previousNumber = currentNumber;
        currentNumber = 0;
        operation = "+";
        resetMonitor2();
    }
    public void ClickMinus()
    {
        previousNumber = currentNumber;
        currentNumber = 0;
        operation = "-";
        resetMonitor2();
    }
    public void ClickMultyly()
    {
        previousNumber = currentNumber;
        currentNumber = 0;
        operation = "*";
        resetMonitor2();
    }
    public void ClickDivide()
    {
        previousNumber = currentNumber;
        currentNumber = 0;
        operation = "/";
        resetMonitor2();
    }
    public void ClickStepen()
    {
        previousNumber = currentNumber;
        currentNumber = 0;
        operation = "^";
        resetMonitor2();
    }


    public void ClickEquals()
    {
        if (operation == "+")
        {
            txtNumbers.text = "Ответ: " + (currentNumber = currentNumber + previousNumber);
            force.gameObject.SetActive(true);
        }
        if (operation == "-")
        {
            txtNumbers.text = "Ответ: " + (currentNumber = previousNumber - currentNumber);
            force.gameObject.SetActive(true);
        }
        if (operation == "*")
        {
            txtNumbers.text = "Ответ: " + (currentNumber = previousNumber * currentNumber);
            force.gameObject.SetActive(true);
        }
        if (operation == "/")
        {
            txtNumbers.text = "Ответ: " + (currentNumber = previousNumber / currentNumber);
            force.gameObject.SetActive(true);
        }
        if (operation == "^")
        {
            txtNumbers.text = "Ответ: " + (currentNumber = Mathf.Pow(previousNumber, currentNumber));
            force.gameObject.SetActive(true);
        }
        resetMonitor3();
    }

    public void resetMonitor()
    {
        if (currentNumber != 0)
            txtNumbers.text = currentNumber + "";
    }

    public void resetMonitor2()
    {

        txtNumbers.text = operation + "" ;

    }
    public void resetMonitor3()
    {

        txtNumbers.text = currentNumber + "";
        force.gameObject.SetActive(true);
    }

    public void Clear()
    {
        currentNumber = 0;
        previousNumber = 0;
        operation = "";
        resetMonitor();
    }


}
