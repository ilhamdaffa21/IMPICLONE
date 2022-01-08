using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public GameObject canvasTutorial,canvasMain;
    public void LoadScene()
    {
        canvasTutorial.SetActive(true);
        canvasMain.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
