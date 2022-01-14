using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControl : MonoBehaviour
{
    public GameObject canvasStory;
    // Start is called before the first frame update

    void Start()
    {
        canvasStory.SetActive(false);
    }
}
