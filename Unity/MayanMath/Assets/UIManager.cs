using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;
    [SerializeField] GameObject HUD;

    public TextMeshProUGUI CurrentTime;
    public TextMeshProUGUI RecordTime;

    float Timer;
    bool Paused = false;
    UnityStandardAssets.Characters.FirstPerson.FirstPersonController Player;

    private void Start()
    {
        Time.timeScale = 1;

        Timer = 0;
        float Record = PlayerPrefs.GetFloat($"Record_{SceneManager.GetActiveScene().name}");
        string Minutes = Mathf.Floor(Record / 60).ToString("00");
        string Seconds = Mathf.Floor(Record % 60).ToString("00");
        RecordTime.text = $"{Minutes}:{Seconds}";

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        Player = GameObject.FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
    }

    private void Update()
    {
        Timer += Time.deltaTime;
        string Minutes = Mathf.Floor(Timer / 60).ToString("00");
        string Seconds = Mathf.Floor(Timer % 60).ToString("00");
        CurrentTime.text = $"{Minutes}:{Seconds}";

        if (Input.GetButtonDown("PauseButton"))
        {
            if(Paused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Paused = true;
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        HUD.SetActive(false);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Player.enabled = false;
    }

    public void ResumeGame()
    {
        Paused = false;
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        HUD.SetActive(true);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Player.enabled = true;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}