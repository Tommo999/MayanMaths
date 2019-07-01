using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public string LevelName;

    private void OnTriggerEnter(Collider Other)
    {
        if(Other.tag == "Player")
        {
            LoadLevel();    
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
