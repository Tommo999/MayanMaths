using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator DoorAnim;
    public EquationManager EM;
    public int Answer;
    bool LevelComplete;

    private void Start()
    {
        DoorAnim = GetComponent<Animator>();
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
