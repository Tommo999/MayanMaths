using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public KeyHolder HolderOfKeys;
    bool KeyEntered;
    Animator DoorAnim;

    private void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        DoorAnim.SetBool("LevelComplete", HolderOfKeys.Keytected);
    }
}