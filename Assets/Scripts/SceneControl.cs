using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public AudioSource _audioclick;
    public GameObject canvasTutorial,canvasMain, canvasSetting, canvasCredits;
    public void LoadScene()
    {
        _audioclick.Play();
        canvasTutorial.SetActive(true);
        canvasMain.SetActive(false);
    }

    public void QuitGame()
    {
        _audioclick.Play();
        Application.Quit();
    }
    public void Settings()
    {
        _audioclick.Play();
        canvasSetting.SetActive(true);
        canvasMain.SetActive(false);
        
    }
    public void ResumeSettings()
    {
        _audioclick.Play();
        canvasSetting.SetActive(false);
        canvasMain.SetActive(true);
    }
    public void Credits()
    {
        _audioclick.Play();
        canvasCredits.SetActive(true);
        canvasMain.SetActive(false);

    }
    public void exitCredits()
    {
        _audioclick.Play();
        canvasCredits.SetActive(false);
        canvasMain.SetActive(true);
    }
}
