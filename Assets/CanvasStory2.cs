using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStory2 : MonoBehaviour
{
    Animator animStory2;
    public Animator fadeblack;
    public GameObject canvasStory, canvasGameplay;
    public CanvasStoryParent csp;
    // Start is called before the first frame update
    void Start()
    {
        animStory2 = GetComponent<Animator>();
        DontDestroyOnLoad(gameObject);
        StartCoroutine(waitStory2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waitStory2()
    {
        yield return new WaitForSeconds(25f);
        animStory2.SetTrigger("Story2End");
        csp.getParameter(true);
        yield return new WaitForSeconds(2f);
        canvasStory.SetActive(false);
        canvasGameplay.SetActive(true);
        fadeblack.SetTrigger("usTransition");
    }
}
