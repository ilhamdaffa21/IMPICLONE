using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentTeleporter;
    public AudioSource _audioOpenPintu;
    GrabController gc;
    public Animator animtransition;
    bool onGrab = false;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && !onGrab)
        {
            if (currentTeleporter != null)
            {
                _audioOpenPintu.Play();
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
                animtransition.SetTrigger("isTransition");

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if(collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }

    public void getParameterGrab(bool parameter)
    {
        onGrab = parameter;
    }

}
