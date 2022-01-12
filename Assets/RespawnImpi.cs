using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnImpi : MonoBehaviour
{
    public GameObject GameOverUI;
    Transform spawnPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print(spawnPosition.position.x);
        //print(spawnPosition.position.y);
    }
    public void respawnImpi(Transform parameter)
    {
        ////print("isi parameter " + parameter.position.x);
        ////spawnPosition = parameter;
        ////gameObject.transform.position = new Vector3(spawnPosition.position.x, spawnPosition.position.y, 0);
        //GameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;


    }
}
    