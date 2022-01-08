using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public GameObject canvasTutorial;
    public void LoadScene()
    {
        canvasTutorial.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
