using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStoryParent : MonoBehaviour
{
    //bool isAlreadyPlay = false;
    public GameObject gameplay;
    // Start is called before the first frame update
    void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        if (ReloadAgain.isAlreadyStory)
        {
            gameObject.SetActive(false);
            gameplay.SetActive(true);
        }
        print(ReloadAgain.isAlreadyStory);
    }

    // Update is called once per frame
    void Update()
    {
        print(ReloadAgain.isAlreadyStory);
    }

    public void getParameter(bool parameter)
    {
        ReloadAgain.isAlreadyStory = parameter;
    }
}
