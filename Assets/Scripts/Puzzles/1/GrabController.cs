using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDist;
    Movement mov;
    Animator _animimpi;
    // Start is called before the first frame update
    void Start()
    {
        mov = GetComponent<Movement>();
        _animimpi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D grabcheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);
        if (grabcheck.collider != null && grabcheck.collider.tag == "Box")
        {
            if (Input.GetKey(KeyCode.G))
            {
                _animimpi.SetBool("isImpiWalkGrab", true);
                _animimpi.SetBool("isImpiWalk", false);
                mov.getParameterGrab(true);
                grabcheck.collider.gameObject.transform.parent = boxHolder;
                grabcheck.collider.gameObject.transform.position = boxHolder.position;
                grabcheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else
            {
                _animimpi.SetBool("isImpiWalkGrab", false);
                mov.getParameterGrab(false);
                grabcheck.collider.gameObject.transform.parent = null;
                grabcheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }
}