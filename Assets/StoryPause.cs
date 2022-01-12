using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(stopTimeScale());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator stopTimeScale()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
        //Time.timeScale = 1;
    }
}
