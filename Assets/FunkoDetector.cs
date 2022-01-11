using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunkoDetector : MonoBehaviour
{
    public AudioSource _audiodesis;
    bool isAvailDesis = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Enemy") && isAvailDesis)
        {
            print("funko desis");
            _audiodesis.Play();
        }
    }
    
    public void getParameter(bool param)
    {
        isAvailDesis = param;
    }
}
