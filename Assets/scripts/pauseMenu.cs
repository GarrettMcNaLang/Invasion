using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public static bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(0);
            if (ispaused)
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
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }
    public void GotoMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        ispaused = false;
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log(0);
    }
}
