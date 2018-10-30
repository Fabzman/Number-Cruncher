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
        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * Speed, rb.velocity.y, Input.GetAxisRaw("Vertical") * Speed);
        //movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        //moveSpeed = movement * Speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Punching");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetTrigger("Not Punching");
        }
    }

    //private void FixedUpdate()
    //{
    //    rigidBody.velocity = moveSpeed;
    //}
}
