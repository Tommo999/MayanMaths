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
        if (Time.timeSinceLevelLoad < 
            PlayerPrefs.GetFloat($"Record_{SceneManager.GetActiveScene().name}") ||
            PlayerPrefs.GetFloat($"Record_{SceneManager.GetActiveScene().name}") == 0)
        {
            PlayerPrefs.SetFloat($"Record_{SceneManager.GetActiveScene().name}",
            Time.timeSinceLevelLoad);
            Debug.Log($"Record_{SceneManager.GetActiveScene().name}");
            Debug.Log(Time.timeSinceLevelLoad);
        }
        SceneManager.LoadScene(LevelName);
    }
}
