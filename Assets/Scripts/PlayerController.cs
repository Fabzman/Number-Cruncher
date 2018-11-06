using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;
    public Rigidbody rb;
    private Vector3 movement;
    private Vector3 moveSpeed;
    private Animator anim;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.SetTrigger("Not Punching");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //anim.SetTrigger("Turn Left");
            //transform.Rotate(0f, 0f, 0f);
            transform.Rotate(0f, 0f, 180f, Space.World);
        }

        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    return;
        //}

        if (Input.GetKeyDown(KeyCode.D))
        {
            //anim.SetTrigger("Turn Right");
            transform.Rotate(0f, 0f, 180f);
        }

        ////if (Input.GetKeyUp(KeyCode.D))
        ////{
        ////    //anim.SetTrigger("Idle");
        ////    return;
        ////}

        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * Speed, rb.velocity.y, Input.GetAxisRaw("Vertical") * Speed);
        //movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        //moveSpeed = movement * Speed;

        if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            anim.SetTrigger("Punching");

        }

        if (Input.GetKeyUp(KeyCode.Keypad0) || Input.GetKeyUp(KeyCode.Keypad1) || Input.GetKeyUp(KeyCode.Keypad2) || Input.GetKeyUp(KeyCode.Keypad3) || Input.GetKeyUp(KeyCode.Keypad4) || Input.GetKeyUp(KeyCode.Keypad5) || Input.GetKeyUp(KeyCode.Keypad6) || Input.GetKeyUp(KeyCode.Keypad7) || Input.GetKeyUp(KeyCode.Keypad8) || Input.GetKeyUp(KeyCode.Keypad9))
        {
            anim.SetTrigger("Not Punching");
        }
    }

    //private void FixedUpdate()
    //{
    //    rigidBody.velocity = moveSpeed;
    //}
}
