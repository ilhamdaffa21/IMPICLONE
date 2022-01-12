using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorySoulStoneSprite : MonoBehaviour
{
    public GameObject[] soulStoneStories;
    int soulstoneid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getParameterId(int parameter)
    {
        soulstoneid = parameter;
        //Time.timeScale = 0;
        soulStoneStories[soulstoneid - 1].SetActive(true);
    }

}
