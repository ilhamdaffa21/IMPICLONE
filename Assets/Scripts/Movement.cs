using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovSpeed;
    public float JumpForce;
    private Rigidbody2D _rigidbody;
    private Vector3 flipScale;
    float  scaleFlip;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovSpeed;
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * 2;
        _rigidbody.velocity = new Vector2(moveBy, _rigidbody.velocity.y);

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
