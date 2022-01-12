using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionBlack : MonoBehaviour
{
    Animator fadeblack;
    // Start is called before the first frame update
    void Start()
    {
        fadeblack = GetComponent<Animator>();
        fadeblack.SetTrigger("isTransition");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
