using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public AudioSource _audioclick;
    public GameObject canvasTutorial,canvasMain;
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
}
