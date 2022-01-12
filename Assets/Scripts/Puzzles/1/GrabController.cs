using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDist;
    bool isGrab = false;
    Movement mov;
    Animator _animimpi;
    PlayerTeleport pt;
    // Start is called before the first frame update
    void Start()
    {
        pt = GetComponent<PlayerTeleport>();
        mov = GetComponent<Movement>();
        _animimpi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D grabcheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);
        if (grabcheck.collider != null && grabcheck.collider.tag == "Box")
        {
            if (Input.GetKeyDown(KeyCode.G) && !isGrab)
            {
                pt.getParameterGrab(true);
                isGrab = true;
                _animimpi.SetBool("isImpiWalkGrab", true);
                _animimpi.SetBool("isImpiWalk", false);
                mov.getParameterGrab(true);
                grabcheck.collider.gameObject.transform.parent = boxHolder;
                grabcheck.collider.gameObject.transform.position = boxHolder.position;
                grabcheck.collider.gameObject.transform.rotation = boxHolder.rotation;
                grabcheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            if(Input.GetKeyUp(KeyCode.G) && isGrab)
            {
                pt.getParameterGrab(false);
                isGrab = false;
                _animimpi.SetBool("isImpiWalkGrab", false);
                mov.getParameterGrab(false);
                grabcheck.collider.gameObject.transform.parent = null;
                grabcheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }
}