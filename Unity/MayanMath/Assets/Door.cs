using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator DoorAnim;
    public EquationManager EM;
    public int Answer;
    bool AnswerMet;

    public GameObject DisplayPanel;
    public Material[] NumberedMaterials = new Material[9];

    private void Start()
    {
        DoorAnim = GetComponent<Animator>();
        if(Answer >= 0 && Answer < NumberedMaterials.Length)
        DisplayPanel.GetComponent<Renderer>().material = NumberedMaterials[Answer];
    }

    void Update()
    {
        if(Answer == EM.Result)
        {
            AnswerMet = true;
        }
        else
        {
            AnswerMet = false;
        }

        DoorAnim.SetBool("LevelComplete", AnswerMet);
    }
}