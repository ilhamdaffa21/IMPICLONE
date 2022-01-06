using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovSpeed;
    public float JumpForce, scaleFlip, moveBy;
    private Rigidbody2D _rigidbody;
    private Vector3 flipScale;
    public double sprintStamina = 100;
    bool staminaFull;
    public Slider sprintValue;
    Animator _animimpi;

    bool isImpiGrab = false;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animimpi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovSpeed;
        float x = Input.GetAxisRaw("Horizontal");

        if (x == 0 && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _animimpi.SetBool("isImpiWalk", false);

        }

        if (x != 0 && (!Input.GetKey(KeyCode.LeftShift) && Mathf.Abs(_rigidbody.velocity.y) < 0.001f) || isImpiGrab)
        {
            //_animimpi.SetBool("isImpiSprint", false);
            _animimpi.SetBool("isImpiWalk", true && Mathf.Abs(_rigidbody.velocity.y) < 0.001f);

        }


        //movement sprint dan tidak
        if (Input.GetKey(KeyCode.LeftShift) && sprintStamina > 0 && !isImpiGrab)
        {
            _rigidbody.velocity = new Vector2(x * 5, _rigidbody.velocity.y);
            sprintStamina -= 1;
            sprintValue.value = (float)sprintStamina;
            _animimpi.SetBool("isImpiSprint", true);

        }
        if ((!Input.GetKey(KeyCode.LeftShift)) || sprintStamina <= 0 || isImpiGrab)
        {
            _rigidbody.velocity = new Vector2(x * 2, _rigidbody.velocity.y);
        }

        //nambah stamina
        if (!staminaFull && (!Input.GetKey(KeyCode.LeftShift)))
        {

            sprintStamina += 1;

            sprintValue.value = (float)sprintStamina;
        }

        //cek apakah stamina penuh
        if (sprintStamina >= 100)
        {
            staminaFull = true;
        }
        if (sprintStamina < 100)
        {
            staminaFull = false;
        }

        //flip
        if (movement < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if (movement > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }



        //if (Mathf.Approximately(0, movement))
        //    transform.rotation = movement > 0 ? Quaternion.Euler(0, 100, 0) : Quaternion.identity;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _animimpi.SetBool("isImpiSprint", false);
            _animimpi.SetBool("ISImpiWalk", false);
            _animimpi.SetTrigger("isImpiJump");
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }


        //
        print(isImpiGrab);

    }

    public void getParameterGrab(bool parameter)
    {
        isImpiGrab = parameter;
    }
}
