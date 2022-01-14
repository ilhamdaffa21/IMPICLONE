using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public GameObject settingsCanvas, pauseCanvas;
    AudioSource _audioclick;

    private void Start()
    {
        _audioclick = GetComponent<AudioSource>();
    }
    public void Pause()
    {
        _audioclick.Play();
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void Resume()
    {
        _audioclick.Play();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ResumeSettings()
    {
        _audioclick.Play();
        settingsCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(int sceneID)
    {
        _audioclick.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
    public void Settings()
    {
        _audioclick.Play();
        settingsCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
    }

    public void Restart()
    {
        _audioclick.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
