using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    Movement mv;
    bool isCrouch = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mv = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector2.zero);

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Crouch"))
        {
            if (Input.GetKey(KeyCode.C) && !isCrouch)
            {
                isCrouch = true;
                gameObject.layer = 8;
                mv.getParameterCrouch(true);
                print("isCrouch = "+isCrouch);
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            if (Input.GetKey(KeyCode.V) && isCrouch)
            {
                 isCrouch = false;
                 gameObject.layer = 0;
                 mv.getParameterCrouch(false);
                 print("isCrouch = " + isCrouch);
                 rb.constraints = RigidbodyConstraints2D.None;
            }
            }
            
        }

    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if(collision.gameObject.tag.Equals("Crouch"))
    //    {
    //        gameObject.layer = 0;
    //        mv.getParameterCrouch(false);
    //    }
    //}
