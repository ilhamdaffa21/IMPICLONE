using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lukisan : MonoBehaviour
{
    public GameObject batuJiwa, sprint, angkaBatu;


    // Start is called before the first frame update
    void Start()
    {
        batuJiwa.SetActive(false);
        sprint.SetActive(false);
        angkaBatu.SetActive(false);
    }

}
