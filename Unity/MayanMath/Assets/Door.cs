using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator DoorAnim;
    public EquationManager EM;
    public int Answer;
    bool LevelComplete;

    public GameObject DisplayPanel;
    public Material[] NumberedMaterials = new Material[9];

    private void Start()
    {
        DoorAnim = GetComponent<Animator>();
        if(Answer >= 0 && Answer < NumberedMaterials.Length)
        DisplayPanel.GetComponent<Renderer>().material = NumberedMaterials[Answer];

        Debug.Log(NumberedMaterials.Length);
    }

    void Update()
    {
        if(Answer == EM.Result)
        {
            LevelComplete = true;
        }
        else
        {
            LevelComplete = false;
        }

        DoorAnim.SetBool("LevelComplete", LevelComplete);
    }
}
