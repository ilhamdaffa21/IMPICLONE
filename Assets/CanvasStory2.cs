using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStory2 : MonoBehaviour
{
    Animator animStory2;
    public Animator fadeblack;
    public GameObject canvasStory, canvasGameplay;
    // Start is called before the first frame update
    void Start()
    {
        animStory2 = GetComponent<Animator>();
        StartCoroutine(waitStory2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waitStory2()
    {
        yield return new WaitForSeconds(10f);
        animStory2.SetTrigger("Story2End");
        yield return new WaitForSeconds(2f);
        canvasStory.SetActive(false);
        canvasGameplay.SetActive(true);
        fadeblack.SetTrigger("usTransition");
    }
}
