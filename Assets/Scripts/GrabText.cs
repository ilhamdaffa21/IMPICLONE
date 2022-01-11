﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrabText : MonoBehaviour
{

    public TextMeshPro tmpro;
    
    // Start is called before the first frame update
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tmpro.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tmpro.gameObject.SetActive(false);
        }
    }
}
