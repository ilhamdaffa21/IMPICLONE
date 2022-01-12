using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LukisanManager : MonoBehaviour
{
    bool isOneDone, isTwoDone, isThreeDone, isFourDone, isFiveDone = false;
    public GameObject batuJiwa, sprint, angkaBatu;
    public GameObject LukisanCanvas;
    CollectObject co;
    StorySoulStoneSprite ss;

    // Start is called before the first frame update
    void Start()
    {
        ss = GameObject.FindGameObjectWithTag("StorySoul").GetComponent<StorySoulStoneSprite>();
        co = GameObject.FindGameObjectWithTag("Player").GetComponent<CollectObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isOneDone && isTwoDone && isThreeDone && isFourDone && isFiveDone)
        {
            LukisanCanvas.SetActive(false);
            batuJiwa.SetActive(true);
            sprint.SetActive(true);
            angkaBatu.SetActive(true);
            co.getSoulStone(1);
            ss.getParameterId(2);
        }
    }
    public void GetParameter(int parameter)
    {
        if (parameter == 1)
        {
            isOneDone = true;
        }
        if (parameter == 2)
        {
            isTwoDone = true;
        }
        if (parameter == 3)
        {
            isThreeDone = true;
        }
        if (parameter == 4)
        {
            isFourDone = true;
        }
        if (parameter == 5)
        {
            isFiveDone = true;
        }
    }
}
