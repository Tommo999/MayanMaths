using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu; //stores your pause menu
    [SerializeField] GameObject HUD; //stores your hud

    public TextMeshProUGUI CurrentTime; //stores text to change for players current time
    public TextMeshProUGUI RecordTime; //stores text to change for players record time

    float Timer; //stores the timer
    bool Paused = false; //stores whether the pause is stored or not
    UnityStandardAssets.Characters.FirstPerson.FirstPersonController Player; //stores the player movement script

    private void Start()
    {
        Time.timeScale = 1; //makes sure game is running at normal speed

        Timer = 0; //resets time taken to complete level
        float Record = PlayerPrefs.GetFloat($"Record_{SceneManager.GetActiveScene().name}"); //gets record to quickly store
        string Minutes = Mathf.Floor(Record / 60).ToString("00"); //gets the time in minutes rounded down
        string Seconds = Mathf.Floor(Record % 60).ToString("00"); //gets the time in seconds rounded down
        RecordTime.text = $"{Minutes}:{Seconds}"; //formats and sets the HUD timer

        Cursor.visible = false; //makes cursor invisible
        Cursor.lockState = CursorLockMode.Locked; //locks cursor to middle of the screen

        Player = GameObject.FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>(); //
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