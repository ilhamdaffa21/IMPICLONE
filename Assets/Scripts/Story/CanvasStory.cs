using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStory : MonoBehaviour
{
    public GameObject gameplayObject, story1, story2;
    Animator animStory1;
    // Start is called before the first frame update
    void Start()
    {
        animStory1 = GetComponent<Animator>();
        gameplayObject.SetActive(false);
        StartCoroutine(waitforStory1());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickStory1()
    {
        print("story1 play");
        animStory1.SetTrigger("story1");
        story2.SetActive(true);
    }

    IEnumerator waitforStory1()
    {
        yield return new WaitForSeconds(32f);
        clickStory1();
    }
}
