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
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        print(sprintStamina);
        var movement = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovSpeed;
        float x = Input.GetAxisRaw("Horizontal");

        //movement sprint dan tidak
        if (Input.GetKey(KeyCode.W) && sprintStamina > 0)
        {
            _rigidbody.velocity = new Vector2(x * 5, _rigidbody.velocity.y);
            sprintStamina -= 1;
            sprintValue.value = (float)sprintStamina;
        }
        if ((!Input.GetKey(KeyCode.W)) || sprintStamina <= 0)
        {
            _rigidbody.velocity = new Vector2(x * 2, _rigidbody.velocity.y);
        }

        //nambah stamina
        if (!staminaFull && (!Input.GetKey(KeyCode.W)))
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
        else if(movement > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }



        //if (Mathf.Approximately(0, movement))
        //    transform.rotation = movement > 0 ? Quaternion.Euler(0, 100, 0) : Quaternion.identity;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }


    }
}
