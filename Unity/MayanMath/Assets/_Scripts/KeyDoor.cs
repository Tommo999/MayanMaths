using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public KeyHolder[] HolderOfKeys;
    bool KeysEntered;
    Animator DoorAnim;

    private void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        foreach(KeyHolder KH in HolderOfKeys)
        {
            if(KH.Keytected)
            {
                KeysEntered = true;
            }
            else
            {
                KeysEntered = false;
                break;
            }
        }
        DoorAnim.SetBool("LevelComplete", KeysEntered);
    }
}