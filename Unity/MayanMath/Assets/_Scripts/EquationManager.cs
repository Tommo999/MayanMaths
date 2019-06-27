using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationManager : MonoBehaviour
{
    public BallHolder Holder1;
    public BallHolder Holder2;
    public string Operation;
    public int Result;

    private void Start()
    {
        Holder1.EM = this;
        Holder2.EM = this;
    }

    public void UpdateValue()
    {
        switch (Operation.ToLower())
        {
            case "+":
            case "addition":
                Addition();
                break;
            //-----
            case "-":
            case "subtraction":
                Subtraction();
                break;
            //-----
            default:
                Debug.Log("No operation selected");
                break;
        }

        Debug.Log("Result: " + Result);
    }

    void Addition()
    {
        if(Holder1 != null && Holder2 != null)
        {
            Result = Holder1.HolderValue + Holder2.HolderValue;
        }
    }

    void Subtraction()
    {
        if (Holder1 != null && Holder2 != null)
        {
            Result = Holder1.HolderValue - Holder2.HolderValue;
        }
    }
}